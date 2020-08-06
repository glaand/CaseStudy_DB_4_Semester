using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class Program
    {
        public static bool OpenWelcomeFormOnClose { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenWelcomeFormOnClose = false;

            Application.Run(new LoginForm());

            if (OpenWelcomeFormOnClose)
            {
                Application.Run(new WelcomeForms());
            }
        }
    }
}
