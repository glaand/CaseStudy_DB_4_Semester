using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class SubscriptionsOrder : ERMTable
    {
        // Attributen der Tabelle
        public int subscription_order_id { set; get; }
        public Subscription subscription { set; get; }

        // Konstruktoren
        public SubscriptionsOrder() : base(null) { }
        public SubscriptionsOrder(int subscription_order_id) : base(subscription_order_id) { }
    }
}
