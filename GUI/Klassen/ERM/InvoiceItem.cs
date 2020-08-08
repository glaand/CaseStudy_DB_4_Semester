using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class InvoiceItem
    {
        public int invoice_item_id { set; get; }
        public Invoice invoice { set; get; }
        public Order order { set; get; }
    }
}
