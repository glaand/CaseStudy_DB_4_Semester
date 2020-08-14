using GUI.Forms.Allgemein;
using GUI.Klassen.ERM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Forms.Buchhaltung
{
    public partial class Buchhaltung : Form
    {
        public Buchhaltung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QueryForm(new Invoice().insertQuery(),this).Show();

        }
    }
}
