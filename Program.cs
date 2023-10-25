
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
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
          

            while (true)
            {
                LoginPage2 loginForm = new LoginPage2();
                RegistrationGUI2 registrationForm = new RegistrationGUI2();

                Application.Run(loginForm);

                if (loginForm.switchRegister)
                {
                    
                    registrationForm.ShowDialog();
                }
                if(loginForm.close == true || loginForm.open == true)
                {
                    break;
                }
            }
        }
    }
 }
