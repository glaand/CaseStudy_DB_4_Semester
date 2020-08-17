using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Addresses
    {
        public Addresses()
        {
            Areas = new HashSet<Areas>();
            Persons = new HashSet<Persons>();
        }

        public int AddressId { get; set; }
        public int PlaceId { get; set; }
        public string Address { get; set; }

        public virtual Places Place { get; set; }
        public virtual ICollection<Areas> Areas { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }

        public string completeAddress()
        {
            return this.Address + ", " + this.Place.PlaceId + " " + this.Place.Place + ", " + this.Place.District.District;
        }
    }
}
