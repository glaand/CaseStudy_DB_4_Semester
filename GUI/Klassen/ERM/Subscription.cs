using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Subscription : ERMTable
    {
        // Attributen der Tabelle
        public int subscription_id { set; get; }
        public string name { set; get; }
        public int duration { set; get; }
        public int rental_properties_quantity { set; get; }
        public double price { set; get; }

        // Konstruktoren
        public Subscription() : base(null) { }
        public Subscription(int subscription_id) : base(subscription_id) { }
    }
}
