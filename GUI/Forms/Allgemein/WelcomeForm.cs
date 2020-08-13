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

        private void areaManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var arealverwaltung = new Areaverwaltung();
            arealverwaltung.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Program.sqlUser = null;
            this.Hide();
            MessageBox.Show("Du hast dich erfolgreich ausgeloggt.", "Ausgeloggt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void personManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var personalverwaltung = new Personalverwaltung();
            personalverwaltung.Show();
        }
    }
}
