using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class Employees : Person
    {
        public int employee_id
        {
            get
            {
                return this.person_id;
            }
            set
            {
                this.person_id = value;
            }
        }
        public EmployeeRoles employeeRole { set; get; }

        public Employees(int person_id) : base(person_id) { }
    }
}
