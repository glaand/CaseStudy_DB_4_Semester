using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// Entity Framework + Tabellen imports
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// END

namespace GUI.Forms.Inspektionsverwaltung
{
    public partial class Inspektionstermin_erstellen : Form
    {
        private List<Inspectors> inspectors;
        private List<Sellers> sellers;

        public Inspektionstermin_erstellen()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.inspectors = Program.db.Inspectors
                .Include(i => i.Person)
                .ToList();
            this.sellers = Program.db.Sellers
                .Include(s => s.Person)
                .ToList();

            List<KeyValuePair<Inspectors, string>> inspectorsItems = new List<KeyValuePair<Inspectors, string>>();
            foreach (Inspectors inspector in this.inspectors)
            {
                inspectorsItems.Add(new KeyValuePair<Inspectors, string>(inspector, inspector.Person.getFullname()));
            }

            inspectorsCombobox.DataSource = new BindingSource(inspectorsItems, null);
            inspectorsCombobox.DisplayMember = "Value";
            inspectorsCombobox.ValueMember = "Key";

            List<KeyValuePair<Sellers, string>> sellersItems = new List<KeyValuePair<Sellers, string>>();
            foreach (Sellers seller in this.sellers)
            {
                sellersItems.Add(new KeyValuePair<Sellers, string>(seller, seller.Person.getFullname() + " (ID: " + seller.SellerId.ToString() + ")"));
            }

            sellerCombobox.DataSource = new BindingSource(sellersItems, null);
            sellerCombobox.DisplayMember = "Value";
            sellerCombobox.ValueMember = "Key";
        }

        private void Inspektionstermin_erstellen_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inspectors inspector = ((KeyValuePair<Inspectors, String>)this.inspectorsCombobox.SelectedItem).Key;
            Sellers seller = ((KeyValuePair<Sellers, String>)this.sellerCombobox.SelectedItem).Key;
            int roundCheck = Convert.ToInt32(this.roundCheckCombobox.SelectedItem.ToString());
            QualityChecks qc = new QualityChecks
            {
                Inspector = inspector,
                Seller = seller,
                Approved = false,
                RoundCheck = (byte)roundCheck
            };

            Program.db.Database.BeginTransaction();
            try
            {
                Program.db.QualityChecks.Add(qc);
                Program.db.SaveChanges();
                Program.db.Database.CommitTransaction();
                MessageBox.Show("Die Inspektions wurde erfolgreicht erstellt!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten, bitte IT melden");
                Program.db.Database.RollbackTransaction();
            }
        }
    }
}
