using GUI.Tabellen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public static class Program
    {

        public static CustomMarktverwaltungssystemContext db { get; set; }

        public static bool CheckConnection()
        {
            try
            {
                Program.db.Database.OpenConnection();
                Program.db.Database.CloseConnection();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
