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

            Assets.Models.IModel model = new Assets.Models.Model();
            CustomerView mainView = new CustomerView(model);   
            IController cnt = new Controller(mainView, model);

            mainView.SetController(cnt);
            mainView.RegisterView();
            Application.Run(mainView);
        }
    }
}
