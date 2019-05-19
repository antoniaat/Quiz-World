using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;
using System;
using System.Windows.Forms;

namespace Quiz_MDI_Application
{
    public static class StartUp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Database.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
