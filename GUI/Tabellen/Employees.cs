using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Employees
    {
        public Employees()
        {
            Areas = new HashSet<Areas>();
            CreditChecks = new HashSet<CreditChecks>();
            Events = new HashSet<Events>();
        }

        public int EmployeeId { get; set; }
        public int EmployeeRoleId { get; set; }
        public decimal HourlySalary { get; set; }

        public virtual Persons Person { get; set; }
        public virtual EmployeeRoles EmployeeRole { get; set; }
        public virtual ICollection<Areas> Areas { get; set; }
        public virtual ICollection<CreditChecks> CreditChecks { get; set; }
        public virtual ICollection<Events> Events { get; set; }

    }
}
