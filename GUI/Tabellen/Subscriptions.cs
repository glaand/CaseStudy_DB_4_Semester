using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Subscriptions
    {
        public Subscriptions()
        {
            Sellers = new HashSet<Sellers>();
            SubscriptionsOrders = new HashSet<SubscriptionsOrders>();
        }

        public int SubscriptionId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public byte RentalPropertiesQuantity { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Sellers> Sellers { get; set; }
        public virtual ICollection<SubscriptionsOrders> SubscriptionsOrders { get; set; }
    }
}
