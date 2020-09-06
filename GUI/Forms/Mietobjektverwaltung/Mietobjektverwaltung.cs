using GUI.Forms.Arealverwaltung;
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Forms.Mietobjektverwaltung
{
    public partial class Mietobjektverwaltung : Form
    {

        private Areas area;
        private void loadListview()
        {

            listView1.Items.Clear();
            foreach (RentalProperties rentalProperty in area.RentalProperties)
            {
                listView1.Items.Add(new ListViewItem(new[]
                {
                    rentalProperty.RentalPropertyId.ToString(),
                    rentalProperty.Area.AreaId.ToString(),
                    rentalProperty.Square.ToString()
                }));
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public Mietobjektverwaltung(Areas area)
        {
            this.area = area;
            InitializeComponent();
        }

        private void Mietobjektverwaltung_Activated(object sender, System.EventArgs e)
        {
            this.loadListview();
            if (this.area.RentalProperties.Count > 0)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = true;
            } 
            else
            {
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bist du sicher, dass du die Mietobjekte löschen möchtest?", "Mietobjekte löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Program.db.RentalProperties.RemoveRange(this.area.RentalProperties);
                    Program.db.SaveChanges();
                    MessageBox.Show("Erfolgreich gelöscht");
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null && ex.InnerException.Message.Contains("permission was denied"))
                    {
                        MessageBox.Show("Du hast keine Berechtigungen dafür.");
                    } else
                    {
                        MessageBox.Show("Ein Fehler ist aufgetreten.");
                    }
                }
                this.loadListview();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new Mietobjekte_erstellen(this.area).Show();
        }
    }
}
