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
    public partial class AnimalReseptionForm : Form
    {
        public AnimalReseptionForm()
        {
            InitializeComponent();
        }
        public AnimalReseption AnimalReseption { get; set; }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnimalReseptionForm_Load(object sender, EventArgs e)
        {
            AnimalReseption = new AnimalReseption();
            textBox1.Text = AnimalReseption.From;
            textBox3.Text = AnimalReseption.Ill;
           // comboBox1.SelectedValue = AnimalReseption.Rarity;
           // comboBox2.SelectedValue = AnimalReseption.condition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalReseption.From = textBox1.Text;
            AnimalReseption.Ill = textBox3.Text;
            switch (comboBox1.SelectedValue?.ToString())
            {
                case "Probably disappeared":
                    AnimalReseption.Rarity = Rarity.probablyDisappeared;
                    break;
                case "Threatened with extinction":
                    AnimalReseption.Rarity = Rarity.threatenedWithExtinction;
                    break;
                case "DwindlingIn numbers":
                    AnimalReseption.Rarity = Rarity.dwindlingInNumbers;
                    break;
                case "rare":
                    AnimalReseption.Rarity = Rarity.rare;
                    break;
            }
            switch (comboBox2.SelectedValue?.ToString())
            {
                case "good":
                    AnimalReseption.condition = Condition.good;
                break;
                case "normal":
                    AnimalReseption.condition = Condition.normal;
                break;
                case "bad":
                    AnimalReseption.condition = Condition.bad;
                break;
                case "awful":
                    AnimalReseption.condition = Condition.awful;
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
