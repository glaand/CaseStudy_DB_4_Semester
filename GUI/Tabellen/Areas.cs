using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Areas
    {
        public Areas()
        {
            Events = new HashSet<Events>();
            RentalPermissions = new HashSet<RentalPermissions>();
            RentalProperties = new HashSet<RentalProperties>();
        }

        public int AreaId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int AddressId { get; set; }
        public string AdditionalInfo { get; set; }
        public decimal Square { get; set; }
        public int EmployeeId { get; set; }
        public int LandlordId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Landlords Landlord { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<RentalPermissions> RentalPermissions { get; set; }
        public virtual ICollection<RentalProperties> RentalProperties { get; set; }
    }
}
