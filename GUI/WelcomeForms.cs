using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class WelcomeForms : Form
    {
        public WelcomeForms()
        {
            InitializeComponent();
        }

        private void WelcomeForms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Arealverwaltung = new Arealeverwaltung();
            Arealverwaltung.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
