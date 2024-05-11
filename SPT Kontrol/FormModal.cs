using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPT_Kontrol
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }
        int i;
        private void FormModal_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(Form1.parentX = 350, Form1.parentY = 150);
        }

        private void timerShowModal_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spt963form = new Form2();
            spt963form.Show();
            var first = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (first != null)
                first.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 spt962form = new Form3();
            spt962form.Show();
            var first = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (first != null)
                first.Hide();
        }
    }
}
