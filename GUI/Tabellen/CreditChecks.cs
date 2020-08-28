using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class CreditChecks
    {
        public int CreditCheckId { get; set; }
        public int EmployeeId { get; set; }
        public int SellerId { get; set; }
        public DateTime VisitDate { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedOn { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual Sellers Seller { get; set; }
    }
}
