using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Klassen.ERM
{
    class Area
    {
        public int area_id { set; get; }
        public double latitude { set; get; }
        public double longitude { set; get; }
        public Address address { set; get; }
        public string additional_info { set; get; }
        public double square { set; get; }
        public Employee employee { set; get; }
        public Landlord landlord { set; get; }
    }
}
