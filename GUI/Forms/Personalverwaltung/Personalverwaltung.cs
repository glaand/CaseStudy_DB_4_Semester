using GUI.Forms.Allgemein;
using GUI.Klassen.ERM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Personalverwaltung : Form
    {
        private List<dynamic> dataList;
        private Person currentPerson;
        public Personalverwaltung()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.dataList = (new Person()).selectAll();
            personListview.Items.Clear();
            foreach (Person person in dataList)
            {
                personListview.Items.Add(new ListViewItem(new[]
                {
                    person.person_id.ToString(),
                    person.firstname,
                    person.lastname,
                    person.email,
                    person.phone_nr,
                    person.manager != null ? person.manager.firstname + " " + person.manager.lastname  : " -- Kein Vorgesetzter --"
                }));
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
                    this.currentPerson = dataList[index];
                    personMenu.Show(Cursor.Position);
                }
            }
        }


        private void personMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
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
            }
        }

        private void insertPerson_Click(object sender, EventArgs e)
        {
            new QueryForm(new Person().insertQuery(), this).Show();
        }
    }
}
