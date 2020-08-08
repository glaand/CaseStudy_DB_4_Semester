using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class SubscriptionsOrder : Order
    {
        public int subscription_order_id
        {
            get
            {
                return this.order_id;
            }
            set
            {
                this.order_id = value;
            }
        }
        public Subscription subscription { set; get; }
    }
}
