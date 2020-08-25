using GUI.Tabellen;
using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI.Forms.Personalverwaltung
{
    public partial class Anbieter_verwalten : Form
    {
        private Sellers seller;
        private List<Subscriptions> subscriptions;
        public Anbieter_verwalten(Sellers seller)
        {
            this.seller = Program.db.Sellers
                .Where(s => s.SellerId == seller.SellerId)
                .Include(s => s.CreditChecks)
                .Include(s => s.Subscription)
                .ToList()[0];
            this.subscriptions = Program.db.Subscriptions.ToList();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Anmeldung___Öko_Bonitätsprüfung(this.seller.Seller).Show();
        }

        private void Anbieter_verwalten_Load(object sender, EventArgs e)
        {
            this.loadData();
            List<KeyValuePair<Subscriptions, string>> subscriptionItems = new List<KeyValuePair<Subscriptions, string>>();
            foreach (Subscriptions subscription in this.subscriptions)
            {
                subscriptionItems.Add(new KeyValuePair<Subscriptions, string>(subscription, subscription.Name));
            }

            comboBox1.DataSource = new BindingSource(subscriptionItems, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void loadData()
        {
            string firstnameTxt = this.seller.Seller.Firstname;
            string lastnameTxt = this.seller.Seller.Lastname;
            string emailTxt = this.seller.Seller.Email;
            string subscriptionTxt = this.seller.Subscription != null ? this.seller.Subscription.Name : "Kein Abonomment";
            string creditcheckTxt = "Noch nicht angemeldet";
            if (this.seller.CreditChecks.Count > 0)
            {
                CreditChecks obj = this.seller.CreditChecks.First();
                creditcheckTxt = obj.VisitDate.ToString();
                if (obj.Approved == true)
                {
                    creditcheckTxt += " (Bestanden)";
                } 
                else
                {
                    creditcheckTxt += " (Nicht bestanden)";
                }
                obj = null;
            }
            

            this.lblFirstname.Text = firstnameTxt;
            this.lblLastname.Text = lastnameTxt;
            this.lblEmail.Text = emailTxt;
            this.lblSubscription.Text = subscriptionTxt;
            this.lblCreditcheck.Text = creditcheckTxt;
        }

        private void Anbieter_verwalten_Activated(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.db.Database.BeginTransaction();
            try
            {
                this.seller.Subscription = ((KeyValuePair<Subscriptions, String>)this.comboBox1.SelectedItem).Key;
                Program.db.SaveChanges();
                Program.db.Database.CommitTransaction();
                MessageBox.Show("Das Abonomment wurde erfolgreich geändert.");
            }
            catch (Exception ex)
            {
                Program.db.Database.RollbackTransaction();
                MessageBox.Show("Ein Fehler ist aufgetreten. Bitte IT kontaktieren.");
            }
        }
    }
}
