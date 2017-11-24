using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer_Contact_Manager_FiveFriday.Assets;

namespace Customer_Contact_Manager_FiveFriday
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

            MainView mainView = new MainView();
            Assets.Models.IModel mdl = new Assets.Models.Model();
            IController cnt = new Controller(mainView, mdl);

            Application.Run(mainView);
        }
    }
}
