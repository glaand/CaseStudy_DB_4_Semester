using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Areal_hinzufügen : Form
    {
        public Areal_hinzufügen()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Areal_hinzufügen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Arealeverwaltung frm = new Arealeverwaltung();
            frm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
