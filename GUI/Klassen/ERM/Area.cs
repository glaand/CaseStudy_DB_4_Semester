using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Area : ERMTable
    {
        // Attributen der Tabelle
        public int area_id { set; get; }
        public decimal latitude { set; get; }
        public decimal longitude { set; get; }
        public Address address { set; get; }
        public string additional_info { set; get; }
        public decimal square { set; get; }
        public Employee employee { set; get; }
        public Landlord landlord { set; get; }

        // Konstruktoren
        public Area() : base(null) { }
        public Area(int area_id) : base(area_id) { }
    }
}
