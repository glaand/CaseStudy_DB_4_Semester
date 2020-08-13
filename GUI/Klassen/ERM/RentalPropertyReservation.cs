using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI.Klassen.ERM
{
    class RentalPropertyReservation : ERMTable
    {
        // Attributen der Tabelle
        public Seller seller { set; get; }
        public RentalProperty rentalProperty { set; get; }

        // Konstruktoren
        public RentalPropertyReservation() : base(null) { }
        public RentalPropertyReservation(Seller pSeller, RentalProperty pRentalProperty) : base(null) {
            // Leider kann diese Tabelle nicht automatisch geladen werden, da sie mit einem
            // zusammengesetzten SChlüssel funktioniert und es denn Aufwand nicht lohnt, ERMTable zu überschreiben
            string whereCondition = "WHERE seller_id = {0} AND rental_property_id = {1}";
            string whereConditionFormatted = string.Format(whereCondition, pSeller.seller_id, pRentalProperty.rental_property_id);
            var rList = this.selectAll(whereConditionFormatted);
            foreach (RentalPropertyReservation obj in rList)
            {
                this.seller = obj.seller;
                this.rentalProperty = obj.rentalProperty;
            }
        }
    }
}
