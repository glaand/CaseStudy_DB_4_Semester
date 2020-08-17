using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class SubscriptionsOrders
    {
        public int SubscriptionOrderId { get; set; }
        public int SubscriptionId { get; set; }

        public virtual Subscriptions Subscription { get; set; }
        public virtual Orders SubscriptionOrder { get; set; }
    }
}
