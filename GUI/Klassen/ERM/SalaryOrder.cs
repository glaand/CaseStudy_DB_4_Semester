using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class SalaryOrder : Order
    {
        public int salary_order_id
        {
            get
            {
                return this.order_id;
            }
            set
            {
                this.order_id = value;
            }
        }
        public Person person { set; get; }
        public double hours { set; get; }
    }
}
