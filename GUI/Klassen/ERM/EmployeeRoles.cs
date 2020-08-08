using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class EmployeeRoles
    {
        public int employee_role_id { get; set; }
        public string name { get; set; }

        public EmployeeRoles(int employee_role_id)
        {
            string query = @"
                SELECT TOP 1
                    employee_role_id,
                    name
                FROM EmployeeRoles
                WHERE EmployeeRoles.employee_role_id = {0};
            ";
            string formattedQuery = string.Format(query, employee_role_id);
            DataTable table = Program.sqlUser.select(formattedQuery);
            foreach (DataRow row in table.Rows)
            {
                this.employee_role_id = (int)row[0];
                this.name = (string)row[1];
            }
        }
    }
}
