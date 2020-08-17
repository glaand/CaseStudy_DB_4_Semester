using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GUI.Tabellen;

namespace GUI.Forms.Personalverwaltung
{
    public partial class Person_eintragen : Form
    {
        public Person_eintragen()
        {
            InitializeComponent();
        }

        private void Person_eintragen_Load(object sender, EventArgs e)
        {
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

            List<Persons> managers = Program.db.Persons.ToList();
            List<KeyValuePair<Persons, string>> managersItems = new List<KeyValuePair<Persons, string>>();

            foreach (Persons manager in managers)
            {
                managersItems.Add(new KeyValuePair<Persons, string>(manager, manager.getFullname()));
            }

            comboBox2.DataSource = new BindingSource(managersItems, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.db.Database.BeginTransaction();
            try
            {
                var person = new Persons
                {
                    Firstname = this.firstname.Text,
                    Lastname = this.lastname.Text,
                    Email = this.email.Text,
                    PhoneNr = this.phone.Text,
                    Address = ((KeyValuePair<Addresses, String>)this.comboBox1.SelectedItem).Key,
                    Manager = ((KeyValuePair<Persons, String>)this.comboBox2.SelectedItem).Key,
                    SqlUserId = 0
                };
                Program.db.Persons.Add(person);
                Program.db.SaveChanges();

                if (this.comboBox3.SelectedItem.ToString() == "Anbieter")
                {
                    var seller = new Sellers
                    {
                        SellerId = person.PersonId,
                        SubscriptionId = 1,
                        Description = this.webprofil.Text,
                        LastUpdate = DateTime.Now.AddHours(-5)
                    };
                    Program.db.Sellers.Add(seller);
                }
                else if (this.comboBox3.SelectedItem.ToString() == "Vermieter")
                {
                    var landlord = new Landlords
                    {
                        LandlordId = person.PersonId
                    };
                    Program.db.Landlords.Add(landlord);
                }
                Program.db.SaveChanges();
                Program.db.Database.CommitTransaction();
                MessageBox.Show("Der Benutzer wurde erfolgreich erstellt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten.");
                Program.db.Database.RollbackTransaction();
            }
        }
    }
}
