using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Forms.Allgemein
{
    public partial class Adressenliste : Form
    {
        private List<Addresses> dataList;
        public Adressenliste()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.dataList = Program.db.Addresses
                .Include(a => a.Place)
                .Include(a => a.Place.District)
                .ToList();

            addressListview.Items.Clear();
            foreach (Addresses address in dataList)
            {
                addressListview.Items.Add(new ListViewItem(new[]
                {
                    address.AddressId.ToString(),
                    address.Place.PlaceId.ToString(),
                    address.Place.District.DistrictId.ToString(),
                    address.Address,
                    address.Place.Place,
                    address.Place.District.District
                }));
            }
            addressListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            addressListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Adressenliste_Activated(object sender, EventArgs e)
        {
            this.loadListview();
        }

    }
}
