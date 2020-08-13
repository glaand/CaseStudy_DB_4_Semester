using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class RentalProperty : ERMTable
    {
        // Attributen der Tabelle
        public int rental_property_id { set; get; }
        public Area area { set; get; }
        public double square { set; get; }

        // Konstruktoren
        public RentalProperty() : base(null) { }
        public RentalProperty(int rental_property_id) : base(rental_property_id) { }
    }
}
