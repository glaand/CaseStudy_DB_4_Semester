using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Inspectors
    {
        public Inspectors()
        {
            QualityChecks = new HashSet<QualityChecks>();
        }

        public int InspectorId { get; set; }
        public decimal HourlySalary { get; set; }

        public virtual Persons Person { get; set; }
        public virtual ICollection<QualityChecks> QualityChecks { get; set; }
    }
}
