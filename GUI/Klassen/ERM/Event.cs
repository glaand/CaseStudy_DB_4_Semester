using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Event
    {
        public int event_id { set; get; }
        public Employee employee { set; get; }
        public Area area { set; get; }
        public string event_date { set; get; }
    }
}
