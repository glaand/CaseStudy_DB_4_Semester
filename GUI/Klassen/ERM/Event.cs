using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Event : ERMTable
    {
        // Attributen der Tabelle
        public int event_id { set; get; }
        public Employee employee { set; get; }
        public Area area { set; get; }
        public string event_date { set; get; }

        // Konstruktoren
        public Event() : base(null) { }
        public Event(int event_id) : base(event_id) { }
    }
}
