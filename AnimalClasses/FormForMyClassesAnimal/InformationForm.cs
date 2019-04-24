using AnimalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForMyClassesAnimal
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }
        public AnimalInformation AnimalInformation { get; set; }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            AnimalInformation = new AnimalInformation();
            textBox1.Text = AnimalInformation.Age;
            textBox2.Text = AnimalInformation.Breed;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalInformation.Age = textBox1.Text;
            AnimalInformation.Breed = textBox2.Text;
            switch (comboBox2.SelectedValue?.ToString())
            { 
                case "Male":
                    AnimalInformation.Gender = Gender.Male;
                    break;
                case "Female":
                    AnimalInformation.Gender = Gender.Female;
                    break;
                
            }
            switch (comboBox3.SelectedValue?.ToString())
            {
                case "crustacean":
                    AnimalInformation.KindAnimal = KindAnimal.crustacean;
                    break;
                case "reptile":
                    AnimalInformation.KindAnimal = KindAnimal.reptile;
                    break;
                case "birdge":
                    AnimalInformation.KindAnimal = KindAnimal.birdge;
                    break;
                case "fish":
                    AnimalInformation.KindAnimal = KindAnimal.fish;
                    break;
                case "amphibia":
                    AnimalInformation.KindAnimal = KindAnimal.amphibia;
                    break;
                case "mammal":
                    AnimalInformation.KindAnimal = KindAnimal.mammal;
                    break;
            }
            switch (comboBox4.SelectedValue?.ToString())
            {
                case "aggressive":
                    AnimalInformation.CharacterAnimal = CharacterAnimal.aggressive;
                    break;
                case "calm":
                    AnimalInformation.CharacterAnimal = CharacterAnimal.calm;
                    break;
                case "quiet":
                    AnimalInformation.CharacterAnimal = CharacterAnimal.quiet;
                    break;
                case "benelovent":
                    AnimalInformation.CharacterAnimal = CharacterAnimal.benevolent;
                    break;
                case "mild":
                    AnimalInformation.CharacterAnimal = CharacterAnimal.mild;
                    break;
            }
        }
    }
}
