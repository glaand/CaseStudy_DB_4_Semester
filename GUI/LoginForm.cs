using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextbox.Text;
            String password = passwordTextbox.Text;
            SqlConnection connection = new SqlConnection(@"Data Source=34.65.73.57;Initial Catalog=Marktverwaltungssystem;Persist Security Info=True;User ID=" + username + ";Password=" + password); // making connection   
            try
            {
                connection.Open();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Error on login!");
                System.Environment.Exit(1);
            }

            if (connection != null && connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Login successfully!");
                Program.OpenWelcomeFormOnClose = true;
                this.Close();
                var welcomeform = new WelcomeForms();
                welcomeform.Show();
            }
            else
            {
                MessageBox.Show("Error on login!");
            }
        }
    }
}
