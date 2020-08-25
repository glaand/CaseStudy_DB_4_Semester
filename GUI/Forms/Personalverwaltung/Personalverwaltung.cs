using GUI.Forms.Allgemein;
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.Forms.Personalverwaltung;

namespace GUI
{
    public partial class Personalverwaltung : Form
    {
        private List<Persons> persons;
        private Persons currentPerson;
        public Personalverwaltung()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.persons = Program.db.Persons
                .Include(p => p.Address)
                .Include(p => p.Address.Place)
                .Include(p => p.Address.Place.District)
                .Include(p => p.Manager)
                .Include(p => p.Sellers)
                .Include(p => p.Landlords)
                .Include(p => p.Inspectors)
                .Include(p => p.Visitors)
                .Include(p => p.Employees)
                .ToList();


            personListview.Items.Clear();
            foreach (Persons person in persons)
            {
                ListViewItem listviewItem = new ListViewItem(new[]
                {
                    person.PersonId.ToString(),
                    person.Firstname,
                    person.Lastname,
                    person.Email,
                    person.PhoneNr,
                    person.Manager != null ? person.Manager.getFullname()  : " -- Kein Vorgesetzter --",
                    person.Address.completeAddress()
                });

                if (person.Sellers != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.Red;
                }
                else if (person.Landlords != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.Yellow;
                }
                else if (person.Inspectors != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.LawnGreen;
                }
                else if (person.Visitors != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.DeepSkyBlue;
                }
                else if (person.Employees != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.Pink;
                }

                personListview.Items.Add(listviewItem);
            }
            personListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            personListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void Personalverwaltung_Activated(object sender, System.EventArgs e)
        {
            loadListview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }

        private void personListview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (personListview.FocusedItem.Bounds.Contains(e.Location))
                {
                    int index = personListview.FocusedItem.Index;
                    this.currentPerson = persons[index];
                    personMenu.Show(Cursor.Position);
                }
            }
        }

        private void insertPerson_Click(object sender, EventArgs e)
        {
            new Person_eintragen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void personMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "manageSeller":
                    new Anbieter_verwalten(this.currentPerson.Sellers).Show();
                    break;
                default:
                    break;
            }
        }
    }
}
