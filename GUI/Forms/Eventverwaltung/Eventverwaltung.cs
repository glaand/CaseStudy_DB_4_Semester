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

namespace GUI.Forms.Eventverwaltung
{
    public partial class Eventverwaltung : Form
    {
        private List<Events> events;
        private Events currentEvent;

        public Eventverwaltung()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.events = Program.db.Events
                .Include(e => e.Area)
                .Include(e => e.Area.Address)
                .Include(e => e.Area.Address.Place)
                .Include(e => e.Area.Address.Place.District)
                .Include(e => e.Employee)
                .Include(e => e.Employee.Person)
                .ToList();

            listView1.Items.Clear();
            foreach (Events e in this.events)
            {
                ListViewItem listviewItem = new ListViewItem(new[]
                {
                    e.EventId.ToString(),
                    e.Employee.Person.getFullname(),
                    e.Area.Address.Place.Place + ", " + e.Area.AdditionalInfo,
                    e.EventDate.ToString()
                });

                listView1.Items.Add(listviewItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Event_erstellen().Show();
        }

        private void Eventverwaltung_Activated(object sender, EventArgs e)
        {
            this.loadData();
        }
    }
}
