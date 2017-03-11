using System;
using System.Windows.Forms;
using TextBasedProgramming.Forms;

namespace TextBasedProgramming
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SplashScreenForm());
            Application.Run(new StartForm());
            //Application.Run(new LoginUserForm());
            //Application.Run(new RegisterUserForm());
            //Application.Run(new MainForm());
        }
    }
}
