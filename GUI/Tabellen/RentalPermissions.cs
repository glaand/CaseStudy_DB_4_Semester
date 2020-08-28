using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class RentalPermissions
    {
        public int RentalPermissionId { get; set; }
        public int AreaId { get; set; }
        public DateTime Date { get; set; }

        public virtual Areas Area { get; set; }
    }
}
