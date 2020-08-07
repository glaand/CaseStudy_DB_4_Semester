using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUI.Klassen;

namespace GUI
{
    public static class Program
    {
        // Beim Program wird der SQLUser verwaltet. Somit können alle Forms auf diese Globale Variabel zugreifen.
        public static SQLUser sqlUser { get; set; }
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
