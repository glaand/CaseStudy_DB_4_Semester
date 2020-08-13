using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class Address : ERMTable
    {
        // Attributen der Tabelle
        public int address_id { set; get; }
        public Place place { set; get; }
        public string address { set; get; }

        // Konstruktoren
        public Address() : base(null) { }
        public Address(int address_id) : base(address_id) { }

        // Methoden
        public override string getTableName()
        {
            return "Addresses";
        }

        public override string ToString()
        {
            return string.Join(", ", new string[] {
                this.address,
                this.place.place_id.ToString(),
                this.place.place,
                this.place.district.district
            });
        }

    }
}
