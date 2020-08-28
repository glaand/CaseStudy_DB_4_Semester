using System;
using System.Collections.Generic;
using System.Windows.Forms;
// Entity Framework + Tabellen imports
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// END
namespace GUI.Forms.Eventverwaltung
{
    public partial class Event_erstellen : Form
    {
        private List<Employees> employees;
        private List<Areas> areas;

        public Event_erstellen()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.employees = Program.db.Employees
                .Include(e => e.Person)
                .ToList();
            this.areas = Program.db.Areas
                .Include(a => a.Address)
                .Include(a => a.Address.Place)
                .Include(a => a.Address.Place.District)
                .Include(a => a.RentalPermissions)
                .ToList();

            List<KeyValuePair<Employees, string>> employeeItems = new List<KeyValuePair<Employees, string>>();
            foreach (Employees employee in this.employees)
            {
                employeeItems.Add(new KeyValuePair<Employees, string>(employee, employee.Person.getFullname()));
            }

            employeeCombobox.DataSource = new BindingSource(employeeItems, null);
            employeeCombobox.DisplayMember = "Value";
            employeeCombobox.ValueMember = "Key";

            List<KeyValuePair<Areas, string>> areasItems = new List<KeyValuePair<Areas, string>>();
            foreach (Areas area in this.areas)
            {
                areasItems.Add(new KeyValuePair<Areas, string>(area, area.Address.Place.Place + ", " + area.AdditionalInfo));
            }

            areaCombobox.DataSource = new BindingSource(areasItems, null);
            areaCombobox.DisplayMember = "Value";
            areaCombobox.ValueMember = "Key";
        }

        private void Event_erstellen_Activated(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employee = ((KeyValuePair<Employees, String>)this.employeeCombobox.SelectedItem).Key;
            Areas area = ((KeyValuePair<Areas, String>)this.areaCombobox.SelectedItem).Key;
            DateTime eventDate = this.dateTimePicker1.Value;

            // Überprüfen ob an diesem Datum, Events in dieses Areal durchgeführt werden dürfen.
            bool allowed = false;
            foreach (RentalPermissions rp in area.RentalPermissions)
            {
                bool isSameDay = (rp.Date.Date == eventDate.Date
                                    && rp.Date.Date.Month == eventDate.Date.Month
                                    && rp.Date.Date.Year == eventDate.Date.Year);
                allowed = allowed || isSameDay;
            }

            if (!allowed)
            {
                MessageBox.Show("An diesem Eventdatum ist beim Areal kein Anlass gestattet.");
            }
            else
            {
                Program.db.Database.BeginTransaction();
                Events obj = new Events
                {
                    Employee = employee,
                    Area = area,
                    EventDate = eventDate
                };
                try
                {
                    Program.db.Events.Add(obj);
                    Program.db.SaveChanges();
                    Program.db.Database.CommitTransaction();
                    MessageBox.Show("Das Event wurde erfolgreich erstellt.");
                }
                catch (Exception ex)
                {
                    Program.db.Database.RollbackTransaction();
                    MessageBox.Show("Ein Fehler ist aufgetreten. Bitte IT kontaktieren.");
                }
            }
        }
    }
}
