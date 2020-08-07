using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Arealeverwaltung : Form
    {
        public Arealeverwaltung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Mieter_hinzufügen = new Mieter_hinzufügen ();
            Mieter_hinzufügen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Areal_hinzufügen = new Areal_hinzufügen();
            Areal_hinzufügen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Mietobjekt_erstellen = new Mietobjekt_erstellen();
            Mietobjekt_erstellen.Show();

        }

        private void Arealeverwaltung_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }
    }
}
