using GUI.Tabellen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Forms.Personalverwaltung
{
    public partial class Anmeldung___Öko_Bonitätsprüfung : Form
    {
        Persons person;
        public Anmeldung___Öko_Bonitätsprüfung(Persons person)
        {
            this.person = person;
            InitializeComponent();
        }

        private void Anmeldung___Öko_Bonitätsprüfung_Load(object sender, EventArgs e)
        {
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

            comboBox1.DataSource = new BindingSource(employeesItems, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.db.Database.BeginTransaction();
            try
            {
                var creditCheck = new CreditChecks
                {
                    Seller = this.person.Sellers,
                    Employee = ((KeyValuePair<Employees, String>)this.comboBox1.SelectedItem).Key,
                    VisitDate = monthCalendar1.SelectionRange.Start,
                    Approved = this.approvedYes.Checked ? true : false,
                    ApprovedOn = monthCalendar1.SelectionRange.Start.AddHours(1) 
                };
                Program.db.CreditChecks.Add(creditCheck);
                Program.db.SaveChanges();

                Program.db.Database.CommitTransaction();
                MessageBox.Show("Der Anbieter wurde erfolgreich für die Öko-Bonitätsprüfung angemeldet.\n\nSiehe Inspektionsverwaltung.");
            }
            catch (Exception ex)
            {
                Program.db.Database.RollbackTransaction();
                if (ex.InnerException.Message.Contains("permission was denied"))
                {
                    MessageBox.Show("Du hast keine Berechtigungen dafür.");
                }
                else
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten.");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
