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
        // Attributen von der Tabelle
        public int person_id { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string email { set; get; }
        public string phone_nr { set; get; }
        public Person manager { set; get; }
        public Address address { set; get; }
        public int sql_user_id { set; get; }

        // Konstruktoren
        public Person() : base(null) {}
        public Person(int person_id) : base(person_id) {}
    }
}
