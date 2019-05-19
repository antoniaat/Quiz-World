using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_MDI_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            User tonka = new User
            {
                Id = 1,
                Username = "Tonka",
                Password = "Raponka",
                Role = UserRole.Admin
            };

            DataAccess da = new DataAccess();
            da.CreateUser(tonka);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
        }
    }
}
