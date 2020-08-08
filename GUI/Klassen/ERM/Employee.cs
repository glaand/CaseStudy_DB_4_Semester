using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class Employee : Person
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
        public EmployeeRole employeeRole { set; get; }

        public Employee(int person_id) : base(person_id) { }
    }
}
