using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI.Forms.Allgemein
{
    public partial class QueryForm : Form
    {
        private string query;
        private Form sourceForm;
        public QueryForm(string query, Form sourceForm)
        {
            this.query = query;
            this.sourceForm = sourceForm;
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.sqlUser.OpenConnection();
            Program.sqlUser.transaction = Program.sqlUser.connection.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(this.textBox1.Text, Program.sqlUser.connection, Program.sqlUser.transaction);
                cmd.ExecuteNonQuery();
                Program.sqlUser.transaction.Commit();
                MessageBox.Show("SQL Query/Queries erfolgreich ausgeführt");
                Program.sqlUser.connection.Close();
                this.Hide();
                this.sourceForm.Show();
            }
            catch (Exception ex)
            {
                Program.sqlUser.transaction.Rollback();
                if (ex.ToString().Contains("permission") && ex.ToString().Contains("permission"))
                {
                    MessageBox.Show("Keine Berechtigungen für diese Aktion.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Program.sqlUser.CloseConnection();
        }
    }
}
