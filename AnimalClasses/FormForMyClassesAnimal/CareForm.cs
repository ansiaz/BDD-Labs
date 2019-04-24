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
    public partial class CareForm : Form
    {
        public CareForm(CareService careService)
        {
            CareService = careService;
            InitializeComponent();
        }
        public CareService CareService { get; set; }

        private void CareForm_Load(object sender, EventArgs e)
        {
            textBox2.Text = CareService.Description;
            dateTimePicker1.Value = CareService.MaintananceDate;
            if (CareService.NextPlannedService.HasValue)
                dateTimePicker2.Value = CareService.NextPlannedService.Value;
            else
                dateTimePicker2.Checked = false;
            checkBox1.Checked = CareService.IsPlannedService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CareService.Description = textBox1.Text;
            CareService.MaintananceDate = dateTimePicker1.Value;
            CareService.IsPlannedService = checkBox1.Checked;
            if (!dateTimePicker2.Checked)
            {
                CareService.NextPlannedService = null;
            }
            else
            {
                CareService.NextPlannedService = dateTimePicker2.Value;
            }
        }
    }
}
