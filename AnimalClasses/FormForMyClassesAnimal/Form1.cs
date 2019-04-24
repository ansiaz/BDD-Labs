using AnimalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FormForMyClassesAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ff = new AnimalReseptionForm() {AnimalReseption = new AnimalReseption() };
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(ff.AnimalReseption);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = listBox1.SelectedItem is AnimalReseption;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (AnimalReseption)listBox1.Items[index];
                var ff = new AnimalReseptionForm() { AnimalReseption = item };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    listBox1.Items.Remove(item);
                    listBox1.Items.Insert(index, item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is AnimalReseption)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ff = new CareForm(new CareService { MaintananceDate = DateTime.Now });
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox2.Items.Add(ff.CareService);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is CareService)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = listBox2.SelectedItem is CareService;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Зоопарк|*.Animal" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;
            var AnimalInformation = new AnimalInformation()
            {
                Nickname = textBox1.Text,
            };

            var Animal = new Animal ()
            {
                Journal = listBox1.Items.OfType<AnimalReseption>().ToList(),
                CareService = listBox2.Items.OfType<CareService>().ToList(),
            };

            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            Animal.Photo = stream.ToArray();


            switch (comboBox1.SelectedValue?.ToString())
            {
                case "Воздушный":
                    AnimalInformation.AnimalType= AnimalType.aerial;
                    break;
                case "Наземный":
                    AnimalInformation.AnimalType = AnimalType.terrestrial;
                    break;
                default:
                    AnimalInformation.AnimalType= AnimalType.underwater;
                    break;
            }

            var xs = new XmlSerializer(typeof(AnimalInformation));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, Animal);
            file.Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Зоопарк|*.Animal" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(AnimalInformation));
            var xk = new XmlSerializer(typeof(Animal));
            var file = File.OpenRead(ofd.FileName);
            var animalInformation = (AnimalInformation)xs.Deserialize(file);
            var animal = (Animal)xk.Deserialize(file);
            file.Close();

            textBox1.Text = animalInformation.Nickname;
            dateTimePicker1.Value = animalInformation.DateOfBithday;
            switch (animalInformation.AnimalType)
            {
                case AnimalType.aerial:
                    comboBox1.Text = "Воздушный";
                    break;
                case AnimalType.terrestrial:
                    comboBox1.Text = "Наземный";
                    break;
                case AnimalType.underwater:
                    comboBox1.Text = "Подводный";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var ms = new MemoryStream(animal.Photo);
            pictureBox1.Image = Image.FromStream(ms);

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var flight in animal.Journal)
            {
                listBox1.Items.Add(flight);
            }
            foreach (var sm in animal.CareService)
            {
                listBox2.Items.Add(sm);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var ff = new InformationForm() { AnimalInformation = new AnimalInformation() };
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox3.Items.Add(ff.AnimalInformation);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem is AnimalInformation )
            {
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }

    }
}
