using GUI.Klassen.ERM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GUI.Klassen
{
    public class SQLUser
    {

        private string connectionString = @"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}";
        private string ipAddress = "34.65.73.57";
        private string database = "Marktverwaltungssystem";
        private string username;
        private string password;
        public SqlConnection connection;
        public SqlTransaction transaction;
        public bool isLoggedIn = false;

        // Datenbankrollen
        private string[] roles = new string[] { "customerService", "areaManagement", "qualityInspection", "accounting", "informationPlatform" };
        public string currentRole = "";

        // Daten
        public Person person;

        public SQLUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void login()
        {
            string formattedConnectionString = string.Format(this.connectionString, this.ipAddress, this.database, this.username, this.password);
            this.connection = new SqlConnection(formattedConnectionString);
            try
            {
                this.connection.Open();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                isLoggedIn = false;
            }

            if (connection != null && connection.State == ConnectionState.Open)
            {
                // Das Login war erfolgreich
                this.connection.Close();
                isLoggedIn = true;
                this.fetchSQLUser();
            }
            else
            {
                isLoggedIn = false;
            }
        }

        public void OpenConnection()
        {
            if (this.connection.State == ConnectionState.Closed)
            {
                this.connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        private void fetchSQLUser()
        {
            string query = @"
                SELECT TOP 1
                    person_id
                FROM Persons
                WHERE Persons.sql_user_id = (SELECT principal_id FROM sys.database_principals WHERE name = '{0}');
            ";
            string formattedQuery = string.Format(query, this.username);
            DataTable table = this.select(formattedQuery);
            if (table.Rows.Count < 1)
            {
                // Dieser Meldung erscheint wenn der SQL User kein Person-Eintrag hat.
                MessageBox.Show("Du hast noch kein Profil. \n\nBitte kontaktiere den Datenbankadministrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            foreach (DataRow row in table.Rows)
            {
                int personId = (int)row[0];
                this.person = new Person(personId);
            }

            // Die 1. zugewiesene Rolle finden
            foreach (string role in this.roles)
            {
                DataTable roleTable = this.select("SELECT IS_MEMBER('" + role + "');");
                foreach (DataRow row in roleTable.Rows)
                {
                    if (Convert.IsDBNull(row[0]) == false)
                    {
                        if ((int)row[0] == 1)
                        {
                            this.currentRole = role;
                        }
                    }
                }
            }
        }


        // Methode zum eine SELECT Query auszuführen
        public DataTable select(string query)
        {
            SqlCommand cmd = new SqlCommand(query, this.connection);
            DataTable table = new DataTable();
            this.OpenConnection();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(table);
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("permission") && ex.ToString().Contains("permission"))
                {
                    MessageBox.Show("Keine Berechtigungen für diese Aktion.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.CloseConnection();
            return table;
        }

        ~SQLUser()
        {
            this.CloseConnection();
            this.connection = null;
        }

    }
}
