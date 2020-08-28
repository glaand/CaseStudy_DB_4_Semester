using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Events
    {
        public int EventId { get; set; }
        public int EmployeeId { get; set; }
        public int AreaId { get; set; }
        public DateTime EventDate { get; set; }

        public virtual Areas Area { get; set; }
        public virtual Employees Employee { get; set; }
    }
}
