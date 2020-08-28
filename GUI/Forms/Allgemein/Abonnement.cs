using GUI.Tabellen;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Forms.Allgemein
{
    public partial class Abonnement : Form
    {
        private List<Subscriptions> dataList;
        public Abonnement()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.dataList = Program.db.Subscriptions.ToList();

            listView1.Items.Clear();
            foreach (Subscriptions subscription in dataList)
            {
                listView1.Items.Add(new ListViewItem(new[]
                {
                    subscription.SubscriptionId.ToString(),
                    subscription.Name,
                    subscription.Duration.ToString(),
                    subscription.RentalPropertiesQuantity.ToString(),
                    subscription.Price.ToString()
                }));
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Abonnement_Activated(object sender, EventArgs e)
        {
            this.loadListview();
        }
    }
}
