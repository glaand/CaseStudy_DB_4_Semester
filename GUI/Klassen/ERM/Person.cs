using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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

        public Person(int person_id)
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
}
