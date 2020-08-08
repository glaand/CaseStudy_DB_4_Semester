using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Visitor : Person
    {
        public int visitor_id
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
        public string password { set; get; }
        public bool wants_newsletter { set; get; }
    }
}
