using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Order
    {
        public int order_id { set; get; }
        public string created_on { set; get; }
        public double total_price { set; get; }
    }
}
