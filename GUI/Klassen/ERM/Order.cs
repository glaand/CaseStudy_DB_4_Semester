using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Order : ERMTable
    {
        // Attributen der Tabelle
        public int order_id { set; get; }
        public string created_on { set; get; }
        public double total_price { set; get; }

        // Konstruktoren
        public Order() : base(null) { }
        public Order(int order_id) : base(order_id) { }
    }
}
