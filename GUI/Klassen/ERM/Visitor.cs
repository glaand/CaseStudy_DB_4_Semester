using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Visitor : ERMTable
    {
        // Attributen der Tabelle
        public int visitor_id { set; get; }
        public string password { set; get; }
        public bool wants_newsletter { set; get; }

        // Konstruktoren
        public Visitor() : base(null) { }
        public Visitor(int visitor_id) : base(visitor_id) { }
    }
}
