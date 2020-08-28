using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Invoices
    {
        public Invoices()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        public int InvoiceId { get; set; }
        public int PersonId { get; set; }
        public decimal Vat { get; set; }
        public DateTime? PaidOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Persons Person { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
