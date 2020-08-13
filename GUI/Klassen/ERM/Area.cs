using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Area : ERMTable
    {
        // Attributen der Tabelle
        public int area_id { set; get; }
        public double latitude { set; get; }
        public double longitude { set; get; }
        public Address address { set; get; }
        public string additional_info { set; get; }
        public double square { set; get; }
        public Employee employee { set; get; }
        public Landlord landlord { set; get; }

        // Konstruktoren
        public Area() : base(null) { }
        public Area(int area_id) : base(area_id) { }
    }
}
