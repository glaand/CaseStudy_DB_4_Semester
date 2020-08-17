using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Landlords
    {
        public Landlords()
        {
            Areas = new HashSet<Areas>();
        }

        public int LandlordId { get; set; }

        public virtual Persons Person { get; set; }
        public virtual ICollection<Areas> Areas { get; set; }
    }
}
