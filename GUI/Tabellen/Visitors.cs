using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Visitors
    {
        public int VisitorId { get; set; }
        public string Password { get; set; }
        public bool WantsNewsletter { get; set; }

        public virtual Persons Visitor { get; set; }
    }
}
