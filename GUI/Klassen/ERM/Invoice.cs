using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Invoice
    {
        public int invoice_id { get; set; }
        public Person person { set; get; }
        public double vat { set; get; }
        public string paid_on { set; get; }
        public string created_on { set; get; }

    }
}
