using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Sellers
    {
        public Sellers()
        {
            CreditChecks = new HashSet<CreditChecks>();
            QualityChecks = new HashSet<QualityChecks>();
            RentalPropertyReservations = new HashSet<RentalPropertyReservations>();
        }

        public int SellerId { get; set; }
        public int? SubscriptionId { get; set; }
        public string Description { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual Persons Seller { get; set; }
        public virtual Subscriptions Subscription { get; set; }
        public virtual ICollection<CreditChecks> CreditChecks { get; set; }
        public virtual ICollection<QualityChecks> QualityChecks { get; set; }
        public virtual ICollection<RentalPropertyReservations> RentalPropertyReservations { get; set; }

        // Custom
        public bool isQualified()
        {
            if (this.QualityChecks.Count == 2)
            {
                bool? qualified = null;
                foreach (QualityChecks q in this.QualityChecks)
                {
                    if (qualified == null)
                    {
                        qualified = q.Approved;
                    }
                    else
                    {
                        qualified = (bool)qualified && (bool)q.Approved;
                    }
                }
                return (bool)qualified;
            }
            return false;
        }
    }
}
