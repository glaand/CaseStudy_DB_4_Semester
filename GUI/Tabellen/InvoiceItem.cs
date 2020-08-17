using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }

        public virtual Invoices Invoice { get; set; }
        public virtual Orders Order { get; set; }
    }
}
