using GUI.Forms.Allgemein;
using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.Forms.Personalverwaltung;

namespace GUI
{
    public partial class Personalverwaltung : Form
    {
        private List<Persons> persons;
        private Persons currentPerson;
        public Personalverwaltung()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.persons = Program.db.Persons
                .Include(p => p.Address)
                .Include(p => p.Address.Place)
                .Include(p => p.Address.Place.District)
                .Include(p => p.Manager)
                .Include(p => p.Sellers)
                .Include(p => p.Landlords)
                .Include(p => p.Inspectors)
                .Include(p => p.Visitors)
                .Include(p => p.Employees)
                .ToList();


            personListview.Items.Clear();
            foreach (Persons person in persons)
            {
                ListViewItem listviewItem = new ListViewItem(new[]
                {
                    person.PersonId.ToString(),
                    person.Firstname,
                    person.Lastname,
                    person.Email,
                    person.PhoneNr,
                    person.Manager != null ? person.Manager.getFullname()  : " -- Kein Vorgesetzter --",
                    person.Address.completeAddress()
                });

                if (person.Sellers != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.Red;
                }
                else if (person.Landlords != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.Yellow;
                }
                else if (person.Inspectors != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.LawnGreen;
                }
                else if (person.Visitors != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.DeepSkyBlue;
                }
                else if (person.Employees != null)
                {
                    listviewItem.BackColor = System.Drawing.Color.Pink;
                }

                personListview.Items.Add(listviewItem);
            }
            personListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            personListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void Personalverwaltung_Activated(object sender, System.EventArgs e)
        {
            loadListview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }

        private void personListview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (personListview.FocusedItem.Bounds.Contains(e.Location))
                {
                    int index = personListview.FocusedItem.Index;
                    this.currentPerson = persons[index];
                    if (this.currentPerson.Sellers != null)
                    {
                        sellerMenu.Show(Cursor.Position);
                    }
                    else
                    {
                        personMenu.Show(Cursor.Position);
                    }
                }
            }
        }


        private void personMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*switch (e.ClickedItem.Name)
            {
                case "menuPersonEdit":
                    {
                        this.Hide();
                        string query = this.currentPerson.updateQuery();
                        (new QueryForm(query, this)).Show();
                        break;
                    }
                case "menuPersonDelete":
                    {
                        this.Hide();
                        string beforeQuery = "";
                        string query = this.currentPerson.deleteQuery();
                        Landlord landlord = null;
                        Seller seller = null;
                        Inspector inspector = null;
                        Visitor visitor = null;
                        Employee employee = null;
                        
                        try
                        {
                            landlord = new Landlord(this.currentPerson.person_id);
                            seller = new Seller(this.currentPerson.person_id);
                            inspector = new Inspector(this.currentPerson.person_id);
                            visitor = new Visitor(this.currentPerson.person_id);
                            employee = new Employee(this.currentPerson.person_id);
                        }
                        catch (Exception ex)
                        {

                        }

                        if (landlord != null)
                            beforeQuery += landlord.deleteQuery() + "\r\n\r\n";

                        if (seller != null)
                            beforeQuery += seller.deleteQuery() + "\r\n\r\n";

                        if (inspector != null)
                            beforeQuery += inspector.deleteQuery() + "\r\n\r\n";

                        if (visitor != null)
                            beforeQuery += visitor.deleteQuery() + "\r\n\r\n";

                        if (employee!= null)
                            beforeQuery += employee.deleteQuery() + "\r\n\r\n";

                        (new QueryForm(beforeQuery + query, this)).Show();
                        break;
                    }
                case "menuAddLandlord":
                    new QueryForm(new Landlord().insertQuery(this.currentPerson.person_id), this).Show();
                    break;
                case "menuDeleteLandlord":
                    new QueryForm(new Landlord(this.currentPerson.person_id).deleteQuery(), this).Show();
                    break;
                case "menuAddSeller":
                    new QueryForm(new Seller().insertQuery(this.currentPerson.person_id), this).Show();
                    break;
                case "menuDeleteSeller":
                    new QueryForm(new Seller(this.currentPerson.person_id).deleteQuery(), this).Show();
                    break;
                case "menuAddInspector":
                    new QueryForm(new Inspector().insertQuery(this.currentPerson.person_id), this).Show();
                    break;
                case "menuDeleteInspector":
                    new QueryForm(new Inspector(this.currentPerson.person_id).deleteQuery(), this).Show();
                    break;
                case "menuAddVisitor":
                    new QueryForm(new Visitor().insertQuery(this.currentPerson.person_id), this).Show();
                    break;
                case "menuDeleteVisitor":
                    new QueryForm(new Visitor(this.currentPerson.person_id).deleteQuery(), this).Show();
                    break;
                case "menuAddEmployee":
                    new QueryForm(new Employee().insertQuery(this.currentPerson.person_id), this).Show();
                    break;
                case "menuDeleteEmployee":
                    new QueryForm(new Employee(this.currentPerson.person_id).deleteQuery(), this).Show();
                    break;
                default:
                    break;
            }*/
        }

        private void insertPerson_Click(object sender, EventArgs e)
        {
            new Person_eintragen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sellerMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem1":
                    {
                        new Anmeldung___Öko_Bonitätsprüfung(this.currentPerson).Show();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
