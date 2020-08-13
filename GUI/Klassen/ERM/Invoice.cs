using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Invoice : ERMTable
    {
        // Attributen der Tabelle
        public int invoice_id { get; set; }
        public Person person { set; get; }
        public double vat { set; get; }
        public string paid_on { set; get; }
        public string created_on { set; get; }

        // Konstruktoren
        public Invoice() : base(null) { }
        public Invoice(int invoice_id) : base(invoice_id) { }
    }
}
