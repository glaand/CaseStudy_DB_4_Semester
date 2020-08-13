using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class RentalPermission : ERMTable
    {
        // Attributen der Tabelle
        public int rental_permissions_id { set; get; }
        public Area area { set; get; }
        public string date { set; get; }

        // Konstruktoren
        public RentalPermission() : base(null) { }
        public RentalPermission(int rental_permissions_id) : base(rental_permissions_id) { }
    }
}
