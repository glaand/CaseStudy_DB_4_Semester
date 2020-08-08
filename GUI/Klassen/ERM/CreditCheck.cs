﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class CreditCheck
    {
        public int credit_check_id { set; get; }
        public Employee employee { set; get; }
        public Seller seller { set; get; }
        public string visit_date { set; get; }
        public bool approved { set; get; }
        public string approved_on { set; get; }
    }
}
