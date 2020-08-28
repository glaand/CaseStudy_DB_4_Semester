using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Orders
    {
        public Orders()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        public int OrderId { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual SalaryOrders SalaryOrders { get; set; }
        public virtual SubscriptionsOrders SubscriptionsOrders { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
