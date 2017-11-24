using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer_Contact_Manager_FiveFriday.Assets;

namespace Customer_Contact_Manager_FiveFriday
{
    public partial class MainView : Form, Assets.IView, Assets.Models.IModelObserver
    {
        IController controller;
       
        public MainView()
        {
            InitializeComponent();
        }

        //IModelObserverable
        public void UpdateObserver()
        {

        }
        //IView
        public event ViewHandler<IView> viewChanged;
        public void SetController(IController control)
        {
            controller = control;
        }
       





        private void Main_Load(object sender, EventArgs e)
        {
            logo.Image = Customer_Contact_Manager_FiveFriday.Properties.Resources.logomark_90px;
            controller.SelectAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            controller.UpdateCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controller.DeleteCustomer();
        }

    }
}
