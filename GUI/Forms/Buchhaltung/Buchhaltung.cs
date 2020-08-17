using GUI.Forms.Allgemein;
using System;
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
            /*new QueryForm(new Invoice().insertQuery(),this).Show();*/

        }
    }
}
