using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class SalaryOrders
    {
        public int SalaryOrderId { get; set; }
        public int PersonId { get; set; }
        public int Hours { get; set; }

        public virtual Persons Person { get; set; }
        public virtual Orders SalaryOrder { get; set; }
    }
}
