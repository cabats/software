
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

            LoginPage2 loginForm = new LoginPage2();
            RegistrationGUI2 registrationForm = new RegistrationGUI2();
            homePage home = new homePage();

            Application.Run(loginForm);

           

            /*

            while (true)
                        {
                            LoginPage2 loginForm = new LoginPage2();
            RegistrationGUI2 registrationForm = new RegistrationGUI2();
            homePage home = new homePage();

                            Application.Run(loginForm);
                            if(loginForm.open)
                            {
                                home.ShowDialog();
                            }

                            if (loginForm.switchRegister)
                            {
                                registrationForm.ShowDialog();    
                            }

                            if(loginForm.close == true || loginForm.open == true)
                            {
                                break;
                            }
                        }*/
        }
    }
 }
