using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Place : ERMTable
    {
        // Attributen der Tabelle
        public int place_id { set; get; }
        public District district { set; get; }
        public string place { set; get; }

        // Konstruktoren
        public Place() : base(null) { }
        public Place(int place_id) : base(place_id) { }
    }
}
