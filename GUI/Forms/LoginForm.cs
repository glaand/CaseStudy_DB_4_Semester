using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using GUI.Klassen;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            // Falls die Taste ENTER bei der Textbox "Username" gedrückt wird, dann wird der Fokus auf die Textbox "Passwort" gesetzt.
            if (e.KeyCode == Keys.Enter)
            {
                passwordTextbox.Focus();
            }
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            // Falls die Taste ENTER bei der Textbox "Passwort" gedrückt wird, dann wird die Methode loginButton_Click ausgeführt.
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, new EventArgs());
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextbox.Text;
            String password = passwordTextbox.Text;
            loginButton.Text = "Bitte warten...";

            Program.sqlUser = new SQLUser(username, password);
            Program.sqlUser.login();

            if (Program.sqlUser.isLoggedIn)
            {
                MessageBox.Show("Du hast dich erfolgreich eingeloggt.", "Herzlich Willkommen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var welcomeForm = new WelcomeForm();
                welcomeForm.Show();
            } else
            {
                MessageBox.Show("Dein Username oder Passwort ist ungültig. \n\nBitte überprüfe deine Login-Daten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginButton.Text = "Einloggen";
            }
        }
    }
}
