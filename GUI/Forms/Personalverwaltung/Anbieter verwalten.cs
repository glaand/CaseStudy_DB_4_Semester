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
        private Sellers savedSeller;
        private Sellers seller;
        private List<Subscriptions> subscriptions;
        private List<Areas> areas;
        public Anbieter_verwalten(Sellers seller)
        {
            this.savedSeller = seller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Anmeldung___Öko_Bonitätsprüfung(this.seller.Seller).Show();
        }

        private void Anbieter_verwalten_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void loadData()
        {
            this.seller = Program.db.Sellers
                .Where(s => s.SellerId == this.savedSeller.SellerId)
                .Include(s => s.CreditChecks)
                .Include(s => s.QualityChecks)
                .Include(s => s.Subscription)
                .Include(s => s.RentalPropertyReservations)
                .Include("RentalPropertyReservations.RentalProperty")
                .Include("RentalPropertyReservations.RentalProperty.Area")
                .Include("RentalPropertyReservations.RentalProperty.Area.Address")
                .Include("RentalPropertyReservations.RentalProperty.Area.Address.Place")
                .ToList()[0];
            this.subscriptions = Program.db.Subscriptions.ToList();
            this.areas = Program.db.Areas.Include(a => a.Address).Include(a => a.Address.Place).ToList();
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
            string qualitycheck1Txt = "Noch nicht angemeldet";
            string qualitycheck2Txt = "Noch nicht angemeldet";
            if (this.seller.QualityChecks.Count > 0)
            {
                foreach (QualityChecks qc in this.seller.QualityChecks)
                {
                    string tmp = "";
                    if (qc.Approved == true)
                    {
                        tmp += " (Bestanden)";
                    }
                    else
                    {
                        tmp += " (Nicht bestanden)";
                    }
                    if (qc.RoundCheck == 1)
                    {
                        qualitycheck1Txt = qc.ApprovedOn.ToString();
                        qualitycheck1Txt += tmp;
                    }
                    else if (qc.RoundCheck == 2)
                    {
                        qualitycheck2Txt = qc.ApprovedOn.ToString();
                        qualitycheck2Txt += tmp;
                    }
                }
            }
            string webprofilTxt = this.seller.LastUpdate.ToString();

            string rprTxt = "";
            foreach (RentalPropertyReservations rpr in this.seller.RentalPropertyReservations)
            {
                rprTxt += rpr.RentalProperty.Area.Address.Place.Place + ", " + rpr.RentalProperty.Area.AdditionalInfo + "\r\n";
                rprTxt += " -- RP(id: " + rpr.RentalProperty.RentalPropertyId.ToString() + ", Fläche: " + rpr.RentalProperty.Square.ToString() + " m2)\r\n\r\n";
            }

            this.lblFirstname.Text = firstnameTxt;
            this.lblLastname.Text = lastnameTxt;
            this.lblEmail.Text = emailTxt;
            this.lblSubscription.Text = subscriptionTxt;
            this.lblCreditcheck.Text = creditcheckTxt;
            this.lblQualitycheck1.Text = qualitycheck1Txt;
            this.lblQualitycheck2.Text = qualitycheck2Txt;
            this.lblWebprofil.Text = webprofilTxt;
            this.lblRentalproperties.Text = rprTxt;

            List<KeyValuePair<Subscriptions, string>> subscriptionItems = new List<KeyValuePair<Subscriptions, string>>();
            foreach (Subscriptions subscription in this.subscriptions)
            {
                subscriptionItems.Add(new KeyValuePair<Subscriptions, string>(subscription, subscription.Name));
            }

            comboBox1.DataSource = new BindingSource(subscriptionItems, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            List<KeyValuePair<Areas, string>> areaItems = new List<KeyValuePair<Areas, string>>();
            foreach (Areas area in this.areas)
            {
                areaItems.Add(new KeyValuePair<Areas, string>(area, area.Address.Place.Place + ", " + area.AdditionalInfo));
            }

            comboBox2.DataSource = new BindingSource(areaItems, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void Anbieter_verwalten_Activated(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Subscriptions selectedSubscription = ((KeyValuePair<Subscriptions, String>)this.comboBox1.SelectedItem).Key;

            if (this.seller.isQualified())
            {
                Program.db.Database.BeginTransaction();
                try
                {
                    this.seller.Subscription = selectedSubscription;
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
            else
            {
                MessageBox.Show("Dieser Anbieter darf kein anderer Abo haben, da er immer noch provisorisch angemeldet ist.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Mietobjekte_auswählen(((KeyValuePair<Areas, String>)this.comboBox2.SelectedItem).Key, this.seller).Show();
        }
    }
}
