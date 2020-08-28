using System;
using System.Collections.Generic;

namespace GUI.Tabellen
{
    public partial class Persons
    {
        public Persons()
        {
            InverseManager = new HashSet<Persons>();
            Invoices = new HashSet<Invoices>();
            SalaryOrders = new HashSet<SalaryOrders>();
        }

        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public int? ManagerId { get; set; }
        public int AddressId { get; set; }
        public int? SqlUserId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual Persons Manager { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Inspectors Inspectors { get; set; }
        public virtual Landlords Landlords { get; set; }
        public virtual Sellers Sellers { get; set; }
        public virtual Visitors Visitors { get; set; }
        public virtual ICollection<Persons> InverseManager { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<SalaryOrders> SalaryOrders { get; set; }

        public string getFullname()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
