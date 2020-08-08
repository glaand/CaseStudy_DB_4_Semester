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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Arealeverwaltung frm = new Arealeverwaltung();
            frm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createButton.Text = "Bitte warten...";
            Person newPerson = new Person(null);
            newPerson.firstname = firstnameTextbox.Text;
            newPerson.lastname = lastnameTextbox.Text;
            newPerson.email = emailTextbox.Text;
            newPerson.phone_nr = phoneNrTextbox.Text;
            newPerson.manager = null;
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
