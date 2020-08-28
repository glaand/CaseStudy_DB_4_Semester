using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Forms.Arealverwaltung
{
    public partial class Areal_hinzufügen : Form
    {
        public Areal_hinzufügen()
        {
            InitializeComponent();
        }

        private void Areal_hinzufügen_Load(object sender, EventArgs e)
        {
            this.latitude.Minimum = -90;
            this.latitude.Maximum = 90;

            this.longitude.Minimum = -180;
            this.longitude.Maximum = 180;

            this.square.Minimum = 100;
            this.square.Maximum = 9999999;

            List<Addresses> addresses = Program.db.Addresses
                .Include(a => a.Place)
                .Include(a => a.Place.District)
                .ToList();
            List<KeyValuePair<Addresses, string>> addressItems = new List<KeyValuePair<Addresses, string>>();

            foreach (Addresses address in addresses)
            {
                addressItems.Add(new KeyValuePair<Addresses, string>(address, address.completeAddress()));
            }

            comboBox1.DataSource = new BindingSource(addressItems, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            List<Employees> employees = Program.db.Employees
                .Include(e => e.Person)
                .Include(e => e.EmployeeRole)
                .ToList();
            List<KeyValuePair<Employees, string>> employeesItems = new List<KeyValuePair<Employees, string>>();

            foreach (Employees employee in employees)
            {
                string employeeName = employee.Person.getFullname() + " (" + employee.EmployeeRole.Name + ")";
                employeesItems.Add(new KeyValuePair<Employees, string>(employee, employeeName));
            }

            comboBox2.DataSource = new BindingSource(employeesItems, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";


            List<Landlords> landlords = Program.db.Landlords
                .Include(l => l.Person)
                .ToList();
            List<KeyValuePair<Landlords, string>> landlordsItems = new List<KeyValuePair<Landlords, string>>();

            foreach (Landlords landlord in landlords)
            {
                landlordsItems.Add(new KeyValuePair<Landlords, string>(landlord, landlord.Person.getFullname()));
            }

            comboBox3.DataSource = new BindingSource(landlordsItems, null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar1.SelectionRange.Start;
            DateTime end = monthCalendar1.SelectionRange.End;
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (monthCalendar1.BoldedDates.Contains(date))
                {
                    monthCalendar1.RemoveBoldedDate(date);
                }
                else
                {
                    monthCalendar1.AddBoldedDate(date);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.db.Database.BeginTransaction();
            try
            {
                var area = new Areas
                {
                    Latitude = this.latitude.Value,
                    Longitude = this.longitude.Value,
                    Address = ((KeyValuePair<Addresses, String>)this.comboBox1.SelectedItem).Key,
                    AdditionalInfo = this.textBox1.Text,
                    Square = this.square.Value,
                    Employee = ((KeyValuePair<Employees, String>)this.comboBox2.SelectedItem).Key,
                    Landlord = ((KeyValuePair<Landlords, String>)this.comboBox3.SelectedItem).Key,
                };
                Program.db.Areas.Add(area);
                Program.db.SaveChanges();

                foreach (DateTime permissionDate in monthCalendar1.BoldedDates)
                {
                    var rentalPermission = new RentalPermissions
                    {
                        Area = area,
                        Date = permissionDate
                    };
                    Program.db.RentalPermissions.Add(rentalPermission);
                }
                Program.db.SaveChanges();

                Program.db.Database.CommitTransaction();
                MessageBox.Show("Das Areal wurde erfolgreich eingetragen.");
            }
            catch (Exception ex)
            {
                Program.db.Database.RollbackTransaction();
                MessageBox.Show("Ein Fehler ist aufgetreten.");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
