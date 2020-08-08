using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Landlord : Person
    {
        public int landlord_id
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
    }
}
