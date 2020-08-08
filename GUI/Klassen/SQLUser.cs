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
        public bool isLoggedIn = false;

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
                this.connection.Close();
                isLoggedIn = true;
                this.fetchSQLUser();
            }
            else
            {
                isLoggedIn = false;
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
                MessageBox.Show("Du hast noch kein Profil. \n\nBitte kontaktiere den Datenbankadministrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            foreach (DataRow row in table.Rows)
            {
                int personId = (int)row[0];
                this.person = new Person(personId);
            }
        }


        // Methode zum eine SELECT Query auszuführen
        public DataTable select(string query)
        {
            SqlCommand cmd = new SqlCommand(query, this.connection);
            this.connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            this.connection.Close();
            dataAdapter.Dispose();
            return table;
        }

        ~SQLUser()
        {
            this.connection.Close();
            this.connection = null;
        }

    }
}
