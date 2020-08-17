using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Districts
    {
        public Districts()
        {
            Places = new HashSet<Places>();
        }

        public int DistrictId { get; set; }
        public string District { get; set; }

        public virtual ICollection<Places> Places { get; set; }
    }
}
