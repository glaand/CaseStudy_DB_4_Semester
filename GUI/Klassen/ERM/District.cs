using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class District : ERMTable
    {
        // Attributen der Tabelle
        public int district_id { get; set; }
        public string district { get; set; }

        // Konstruktoren
        public District() : base(null) { }
        public District(int district_id) : base(district_id) { }
    }
}
