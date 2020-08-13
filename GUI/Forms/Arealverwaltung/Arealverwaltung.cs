using GUI.Forms.Allgemein;
using GUI.Klassen.ERM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Areaverwaltung : Form
    {
        private List<dynamic> dataList;
        private Area currentArea;
        public Areaverwaltung()
        {
            InitializeComponent();
        }

        private void loadListview()
        {
            this.dataList = (new Area()).selectAll();
            areaListview.Items.Clear();
            foreach (Area area in dataList)
            {
                Person employeePerson = new Person(area.employee.employee_id);
                Person landlordPerson = new Person(area.landlord.landlord_id);
                areaListview.Items.Add(new ListViewItem(new[]
                {
                    area.area_id.ToString(),
                    area.latitude.ToString(),
                    area.longitude.ToString(),
                    area.address.ToString(),
                    area.additional_info,
                    area.square.ToString(),
                    employeePerson.firstname + " " + employeePerson.lastname + " (" + area.employee.employeeRole.name + ")",
                    landlordPerson.firstname + " " + landlordPerson.lastname
                }));
            }
            areaListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            areaListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm frm = new WelcomeForm();
            frm.Show();
        }

        private void Areaverwaltung_Activated(object sender, EventArgs e)
        {
            this.loadListview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QueryForm(new Area().insertQuery(), this).Show();
        }
    }
}
