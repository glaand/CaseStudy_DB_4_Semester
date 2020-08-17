using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class RentalProperties
    {
        public RentalProperties()
        {
            RentalPropertyReservations = new HashSet<RentalPropertyReservations>();
        }

        public int RentalPropertyId { get; set; }
        public int AreaId { get; set; }
        public decimal Square { get; set; }

        public virtual Areas Area { get; set; }
        public virtual ICollection<RentalPropertyReservations> RentalPropertyReservations { get; set; }
    }
}
