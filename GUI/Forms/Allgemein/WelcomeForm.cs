using GUI.Forms.Allgemein;
using GUI.Forms.Buchhaltung;
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private Persons loadUserPerson()
        {
            Program.db.Database.OpenConnection();

            int sql_user_id = -1;

            using (var command = Program.db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = @"SELECT principal_id FROM sys.database_principals WHERE name = '" + Program.db.username + "'";
                command.CommandType = CommandType.Text;

                using (var reader = command.ExecuteReader())
                {
                    var table = new DataTable();
                    table.Load(reader);
                    foreach (DataRow row in table.Rows)
                    {
                        sql_user_id = (int)row[0];
                        break;
                    }
                }
            }

            if (sql_user_id < 1)
            {
                MessageBox.Show("Du hast noch kein Profil. \n\n Bitte kontaktiere den Datenbankadministrator!");
                System.Environment.Exit(1);
            }

            Persons person = Program.db.Persons.Include(p => p.Manager).First(p => p.SqlUserId == sql_user_id);
            Program.db.Database.CloseConnection();

            return person;
        }

        private void WelcomeForms_Load(object sender, EventArgs e)
        {
            Persons person = this.loadUserPerson();
            firstnameLabel.Text = person.Firstname;
            lastnameLabel.Text = person.Lastname;
            emailLabel.Text = person.Email;
            phoneNrLabel.Text = person.PhoneNr;
            if (person.Manager == null)
            {
                managerLabel.Text = " -- Kein Vorgesetzter --";
            }
            else
            {
                managerLabel.Text = person.Manager.Firstname + " " + person.Manager.Lastname;
            }
        }

        private void areaManagementButton_Click(object sender, EventArgs e)
        {
            var arealverwaltung = new Areaverwaltung();
            arealverwaltung.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Program.db = null;
            this.Hide();
            MessageBox.Show("Du hast dich erfolgreich ausgeloggt.", "Ausgeloggt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void personManagementButton_Click(object sender, EventArgs e)
        {
            var personalverwaltung = new Personalverwaltung();
            personalverwaltung.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adressenliste = new Adressenliste();
            adressenliste.Show();
        }

        private void accountingButton_Click(object sender, EventArgs e)
        {
            var Buchhaltung = new Buchhaltung();
            Buchhaltung.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Abonnement()).Show();
        }
    }
}
