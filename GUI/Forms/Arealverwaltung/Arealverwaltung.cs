using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Areaverwaltung : Form
    {
        public Areaverwaltung()
        {
            InitializeComponent();
        }


        private void Arealeverwaltung_Load(object sender, EventArgs e)
        {
            areaList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            areaList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }
    }
}
