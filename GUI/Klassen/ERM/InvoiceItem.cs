using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class InvoiceItem : ERMTable
    {
        // Attributen der Tabelle
        public int invoice_item_id { set; get; }
        public Invoice invoice { set; get; }
        public Order order { set; get; }

        // Konstruktoren
        public InvoiceItem() : base(null) { }
        public InvoiceItem(int invoice_item_id) : base(invoice_item_id) { }
    }
}
