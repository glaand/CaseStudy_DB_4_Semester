using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class RentalPropertyReservations
    {
        public int SellerId { get; set; }
        public int RentalPropertyId { get; set; }

        public virtual RentalProperties RentalProperty { get; set; }
        public virtual Sellers Seller { get; set; }
    }
}
