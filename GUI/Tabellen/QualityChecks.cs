using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class QualityChecks
    {
        public int QualityCheckId { get; set; }
        public int InspectorId { get; set; }
        public int SellerId { get; set; }
        public byte RoundCheck { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedOn { get; set; }

        public virtual Inspectors Inspector { get; set; }
        public virtual Sellers Seller { get; set; }
    }
}
