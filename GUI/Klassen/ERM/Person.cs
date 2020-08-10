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
    public class Person : ERMTable
    {
        // Data table attributes
        public int person_id { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string email { set; get; }
        public string phone_nr { set; get; }
        public Person manager { set; get; }
        public int sql_user_id { set; get; }

        public Person() : base(null) {}
        public Person(int person_id) : base(person_id) {}

        

        public int save(string personType)
        {
            /*
             * Erstellt eine neue Person und die entsprechende IS-A Tabelle
             */
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
