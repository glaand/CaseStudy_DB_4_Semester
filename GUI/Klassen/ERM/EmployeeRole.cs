using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class EmployeeRole : ERMTable
    {
        // Attributen der Tabelle
        public int employee_role_id { get; set; }
        public string name { get; set; }

        // Konstruktoren
        public EmployeeRole() : base(null) { }
        public EmployeeRole(int employee_role_id) : base(employee_role_id) { }

        // Methoden
        public override string getTableName()
        {
            if (Program.sqlUser.currentRole.Length > 1)
            {
                return "viewEmployeeRoles_" + Program.sqlUser.currentRole;
            }
            return base.getTableName();
        }
    }
}
