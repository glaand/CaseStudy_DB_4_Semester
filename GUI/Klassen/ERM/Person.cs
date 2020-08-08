using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Transactions;

namespace GUI.Klassen.ERM
{
    public class Person
    {
        public int person_id { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string email { set; get; }
        public string phone_nr { set; get; }
        public Person manager { set; get; }
        public int sql_user_id { set; get; }

        public Person(int? person_id = null)
        {
            if (person_id != null)
            {
                string query = @"
                    SELECT TOP 1
                        person_id,
                        firstname,
                        lastname,
                        email,
                        phone_nr,
                        manager_id,
                        sql_user_id
                    FROM Persons
                    WHERE Persons.person_id = {0};
                ";
                string formattedQuery = string.Format(query, person_id);
                DataTable table = Program.sqlUser.select(formattedQuery);
                foreach (DataRow row in table.Rows)
                {
                    this.person_id = (int)row[0];
                    this.firstname = (string)row[1];
                    this.lastname = (string)row[2];
                    this.email = (string)row[3];
                    this.phone_nr = (string)row[4];
                    if (Convert.IsDBNull(row[5]) == false)
                    {
                        this.manager = new Person((int)row[5]);
                    }
                    this.sql_user_id = (int)row[6];
                }
            }
        }

        public int save(string personType)
        {
            int personId = 0;
            SqlTransaction transaction = null;

            string firstQuery = @"
                INSERT INTO Persons (firstname,lastname,email,phone_nr,manager_id)
                VALUES ('{0}','{1}','{2}','{3}',{4});
                SELECT SCOPE_IDENTITY();
            ";

            string secondQuery = "";
            if (personType == "Vermieter")
            {
                secondQuery = @"
                    INSERT INTO Landlords (landlord_id)
                    VALUES ({0});
                    SELECT SCOPE_IDENTITY();
                ";
            }

            Program.sqlUser.connection.Open();
            try
            {
                transaction = Program.sqlUser.connection.BeginTransaction();
                string manager_id = "NULL";
                if (this.manager != null)
                {
                    manager_id = this.manager.person_id.ToString();
                }
                String firstQueryFormatted = string.Format(firstQuery, this.firstname, this.lastname, this.email, this.phone_nr, manager_id);
                using (SqlCommand cmd = new SqlCommand(firstQueryFormatted, Program.sqlUser.connection, transaction))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out personId);
                    }
                }


                // Falls die neue personID von der erstelle Person kleiner als 1 ist, dann stimmt was nicht, also crash fehler melden,
                // um änderungen mit Rollback bei Zeile 93 zurückzusetzen
                if (personId < 1)
                {
                    return 0;
                }

                String secondQueryFormatted = string.Format(secondQuery, personId);
                using (SqlCommand cmd = new SqlCommand(secondQueryFormatted, Program.sqlUser.connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            Program.sqlUser.connection.Close();

            return personId;
        }
    }
}
