using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Seller : ERMTable
    {
        // Attributen der Tabelle
        public int seller_id { set; get; }
        public Subscription subscription { set; get; }
        public string description { set; get; }
        public string last_update { set; get; }

        // Konstruktoren

        public Seller() : base(null) { }
        public Seller(int seller_id) : base(seller_id) { }
    }
}
