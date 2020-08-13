using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Address : ERMTable
    {
        // Attributen der Tabelle
        public int address_id { set; get; }
        public Place place { set; get; }
        public string address { set; get; }

        // Konstruktoren
        public Address() : base(null) { }
        public Address(int address_id) : base(address_id) { }
    }
}
