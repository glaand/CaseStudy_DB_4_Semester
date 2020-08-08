using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Seller : Person
    {
        public int seller_id
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
        public Subscription subscription { set; get; }
        public string description { set; get; }
        public string last_update { set; get; }
    }
}
