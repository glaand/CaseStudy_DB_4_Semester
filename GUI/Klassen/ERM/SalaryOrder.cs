using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class SalaryOrder : ERMTable
    {
        // Attributen der Tabelle
        public int salary_order_id { set; get; }
        public Person person { set; get; }
        public double hours { set; get; }

        // Konstruktoren
        public SalaryOrder() : base(null) { }
        public SalaryOrder(int salary_order_id) : base(salary_order_id) { }
    }
}
