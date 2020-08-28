using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// Entity Framework + Tabellen imports
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// END

namespace GUI.Forms.Inspektionsverwaltung
{
    public partial class Inspektionsverwaltung : Form
    {
        private List<QualityChecks> qualityChecks;
        private QualityChecks currentQualityCheck;
        public Inspektionsverwaltung()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.qualityChecks = Program.db.QualityChecks
                .Include(q => q.Inspector)
                .Include(q => q.Inspector.Person)
                .Include(q => q.Seller)
                .Include(q => q.Seller.Person)
                .ToList();

            listView1.Items.Clear();
            foreach (QualityChecks qc in this.qualityChecks)
            {
                ListViewItem listviewItem = new ListViewItem(new[]
                {
                    qc.QualityCheckId.ToString(),
                    qc.Inspector.Person.getFullname(),
                    qc.Seller.Person.getFullname(),
                    qc.RoundCheck.ToString(),
                    qc.Approved == true ? "JA" : "NEIN",
                    qc.ApprovedOn.ToString()
                });

                listView1.Items.Add(listviewItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Inspektionsverwaltung_Load(object sender, EventArgs e)
        {
            this.loadListview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Inspektionstermin_erstellen().Show();
        }

        private void Inspektionsverwaltung_Activated(object sender, EventArgs e)
        {
            this.loadListview();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.currentQualityCheck.Approved = true;
            this.currentQualityCheck.ApprovedOn = DateTime.Now;

            Program.db.Database.BeginTransaction();
            try
            {
                Program.db.SaveChanges();
                MessageBox.Show("Fertig!");
                Program.db.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                Program.db.Database.RollbackTransaction();
                MessageBox.Show("Ein Fehler ist aufgetreten. Bitte IT kontaktieren.");
            }
        }

        private void Inspektionsverwaltung_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    int index = listView1.FocusedItem.Index;
                    this.currentQualityCheck = this.qualityChecks[index];
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
