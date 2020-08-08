using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Inspector : Person
    {
        public int inspector_id
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
        public double hourly_salary { set; get; }
    }
}
