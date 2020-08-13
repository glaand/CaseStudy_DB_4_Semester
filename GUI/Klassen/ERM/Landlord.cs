using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Landlord : ERMTable
    {
        // Attributen der Tabelle
        public int landlord_id { set; get; }

        // Konstruktoren
        public Landlord() : base(null) { }
        public Landlord(int landlord_id) : base(landlord_id) { }

        // Methoden
        public static List<object> getAllPersons()
        {
            var personList = (new Person()).selectAll(@"
                INNER JOIN Landlords ON Landlords.landlord_id = Persons.person_id
            ");
            return personList;
        }
    }
}
