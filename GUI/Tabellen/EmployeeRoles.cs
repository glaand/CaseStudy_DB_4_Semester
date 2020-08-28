using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class EmployeeRoles
    {
        public EmployeeRoles()
        {
            Employees = new HashSet<Employees>();
        }

        public int EmployeeRoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
