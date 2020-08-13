using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    public class Employee : ERMTable
    {
        // Attributen der Tabelle
        public int employee_id { set; get; }
        public EmployeeRole employeeRole { set; get; }

        // Konstruktoren
        public Employee() : base(null) { }
        public Employee(int employee_id) : base(employee_id) { }

        // Methoden
        public static List<object> getAllPersons()
        {
            var personList = (new Person()).selectAll(@"
                INNER JOIN Employees ON Employees.employee_id = Persons.person_id
            ");
            return personList;
        }
    }
}
