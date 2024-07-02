using PasswordManager.Forms;
using System;
using System.Windows.Forms;

namespace PasswordManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            Application.Run();
        }
    }
}
