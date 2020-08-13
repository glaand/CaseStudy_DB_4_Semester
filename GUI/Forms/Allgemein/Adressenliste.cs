using GUI.Klassen.ERM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Forms.Allgemein
{
    public partial class Adressenliste : Form
    {
        private List<dynamic> dataList;
        public Adressenliste()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.dataList = (new Address()).selectAll();
            addressListview.Items.Clear();
            foreach (Address address in dataList)
            {
                addressListview.Items.Add(new ListViewItem(new[]
                {
                    address.address_id.ToString(),
                    address.place.place_id.ToString(),
                    address.place.district.district_id.ToString(),
                    address.address,
                    address.place.place,
                    address.place.district.district
                }));
            }
            addressListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            addressListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Adressenliste_Activated(object sender, EventArgs e)
        {
            this.loadListview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }
    }
}
