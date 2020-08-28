using GUI.Forms.Arealverwaltung;
using GUI.Forms.Mietobjektverwaltung;
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class Areaverwaltung : Form
    {
        private Areas currentArea;
        private List<Areas> areas;
        public Areaverwaltung()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            areas = Program.db.Areas
                .Include(a => a.Address)
                .Include(a => a.Address.Place)
                .Include(a => a.Address.Place.District)
                .Include(a => a.Employee)
                .Include(a => a.Employee.Person)
                .Include(a => a.Landlord)
                .Include(a => a.Landlord.Person)
                .Include(a => a.RentalProperties)
                .Include(a => a.RentalPermissions)
                .ToList();

            areaListview.Items.Clear();
            foreach (Areas area in areas)
            {
                areaListview.Items.Add(new ListViewItem(new[]
                {
                    area.AreaId.ToString(),
                    area.Latitude.ToString(),
                    area.Longitude.ToString(),
                    area.Address.completeAddress(),
                    area.AdditionalInfo,
                    area.Square.ToString(),
                    area.Employee.Person.Firstname + " " + area.Employee.Person.Lastname,
                    area.Landlord.Person.Firstname + " " + area.Landlord.Person.Lastname,
                    area.RentalProperties.Count.ToString(),
                    area.RentalProperties.Count > 0 ? area.RentalProperties.First().Square.ToString() : "--"
                }));
            }
            areaListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            areaListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }

        private void Areaverwaltung_Activated(object sender, EventArgs e)
        {
            this.loadListview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Areal_hinzufügen().Show();
        }

        private void areaListview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* new QueryForm(new RentalProperty().insertQuery(), this).Show();*/
        }

        private void areaListview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (areaListview.FocusedItem.Bounds.Contains(e.Location))
                {
                    int index = areaListview.FocusedItem.Index;
                    this.currentArea = this.areas[index];
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem1":
                    {
                        new Mietobjektverwaltung(this.currentArea).Show();
                        break;
                    }
                case "toolStripMenuItem2":
                    {
                        try
                        {
                            Program.db.Areas.Remove(this.currentArea);
                            Program.db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Löschen.\n\nVersuch zuerst die Mietobjekte zu löschen.");
                        }
                        break;
                    }
                case "toolStripMenuItem3":
                    {
                        new Areal_bearbeiten(this.currentArea).Show();
                        break;
                    }
                case "toolStripMenuItem4":
                    {
                        try
                        {
                            List<RentalPermissions> eventDates = this.currentArea.RentalPermissions.ToList();
                            string msg = "An folgende Tagen sind Events bei diesem Areal erlaubt:\r\n\r\n";
                            foreach (RentalPermissions eventDate in eventDates)
                            {
                                msg += eventDate.Date.ToString("dd-MM-yyyy") + "\r\n";
                            }
                            MessageBox.Show(msg);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Auflisten von Eventdaten.");
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
