using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Inspector : ERMTable
    {
        // Attributen der Tabelle
        public int inspector_id { set; get; }
        public double hourly_salary { set; get; }

        // Konstruktoren
        public Inspector() : base(null) { }
        public Inspector(int inspector_id) : base(inspector_id) { }
    }
}
