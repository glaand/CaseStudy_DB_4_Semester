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
    public partial class Person_hinzufügen : Form
    {
        public Person_hinzufügen()
        {
            InitializeComponent();
        }

        public void Person_hinzufügen_Load(object sender, EventArgs e)
        {
            List<object> personList = (new Person()).selectAll();
            Dictionary<Person, string> managerItems = new Dictionary<Person, string>();
            managerItems.Add((new Person()), " -- Kein Vorgesetzter --");
            foreach (Person person in personList)
            {
                managerItems.Add(person, person.firstname + " " + person.lastname);
            }
            managerCombobox.DataSource = new BindingSource(managerItems, null);
            managerCombobox.DisplayMember = "Value";
            managerCombobox.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Arealeverwaltung frm = new Arealeverwaltung();
            frm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Person selectedManager = ((KeyValuePair<Person, string>)managerCombobox.SelectedItem).Key;
            createButton.Text = "Bitte warten...";
            Person newPerson = new Person();
            newPerson.firstname = firstnameTextbox.Text;
            newPerson.lastname = lastnameTextbox.Text;
            newPerson.email = emailTextbox.Text;
            newPerson.phone_nr = phoneNrTextbox.Text;
            newPerson.manager = null;
            if (selectedManager.person_id > 0)
            {
                newPerson.manager = selectedManager;
            }
            int newPersonId = newPerson.save(personType.SelectedItem.ToString());
            if (newPersonId > 0)
            {
                MessageBox.Show("Person erfolgreich erstellt", "Herzlich Willkommen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Fehler beim Speichern in der Datenbank", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            createButton.Text = "Bestätigen";
        }
    }
}
