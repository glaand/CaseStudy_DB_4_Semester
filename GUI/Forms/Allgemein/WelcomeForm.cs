using GUI.Forms.Allgemein;
using GUI.Forms.Eventverwaltung;
using GUI.Forms.Inspektionsverwaltung;
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
            new Areaverwaltung().Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Program.db = null;
            this.Hide();
            MessageBox.Show("Du hast dich erfolgreich ausgeloggt.", "Ausgeloggt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new LoginForm().Show();
        }

        private void personManagementButton_Click(object sender, EventArgs e)
        {
            new Personalverwaltung().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Adressenliste().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Abonnement().Show();
        }

        private void inspectionManagementButton_Click(object sender, EventArgs e)
        {
            new Inspektionsverwaltung().Show();
        }

        private void eventManagementButton_Click(object sender, EventArgs e)
        {
            new Eventverwaltung().Show();
        }
    }
}
