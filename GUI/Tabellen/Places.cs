using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Places
    {
        public Places()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int PlaceId { get; set; }
        public int DistrictId { get; set; }
        public string Place { get; set; }

        public virtual Districts District { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
