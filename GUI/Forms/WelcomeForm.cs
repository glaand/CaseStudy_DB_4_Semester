using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForms_Load(object sender, EventArgs e)
        {
            firstnameLabel.Text = Program.sqlUser.person.firstname;
            lastnameLabel.Text = Program.sqlUser.person.lastname;
            emailLabel.Text = Program.sqlUser.person.email;
            phoneNrLabel.Text = Program.sqlUser.person.phone_nr;
            if (Program.sqlUser.person.manager == null)
            {
                managerLabel.Text = " -- Kein Vorgesetzter --";
            }
            else
            {
                managerLabel.Text = Program.sqlUser.person.manager.firstname + " " + Program.sqlUser.person.manager.lastname;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Arealverwaltung = new Arealeverwaltung();
            Arealverwaltung.Show();
        }


    }
}
