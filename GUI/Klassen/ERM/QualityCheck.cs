using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class QualityCheck
    {
        public int quality_check_id { set; get; }
        public Inspector inspector{ set; get; }
        public Seller seller { set; get; }
        public int round_check { set; get; }
        public bool approved { set; get; }
        public string approved_on { set; get; }
    }
}
