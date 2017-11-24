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
using Customer_Contact_Manager_FiveFriday.Assets.Models;

namespace Customer_Contact_Manager_FiveFriday
{
    public partial class ContactsView : Form, IView, IModelObserver
    {
        IController controller;
        IModel businessModel;
        private int customerID;
        public ContactsView(IModel model)
        {            
            businessModel = model;
            InitializeComponent();
        }
        
        public int CustomerID
        {
            get{ return customerID; }
            set{ customerID = value; }
        }

        //IModelObserverable
        public void UpdateObserver(Assets.Models.IModel model, Assets.Models.ModelEventArgs modelEvents)
        {

            customerContactsListView.Clear();
            CustomerContacts custContacts = null;
            try
            {
                object obj = modelEvents.objectValue;
                bool isCustomerContactsList = obj?.GetType() == typeof(List<CustomerContacts>);
                if (isCustomerContactsList)
                {
                    List<CustomerContacts> listOfCustomerContacts = (List<CustomerContacts>)modelEvents.objectValue;
                    if (listOfCustomerContacts != null)
                    {
                        string[] row = null;
                        for (int z = 0; z < listOfCustomerContacts.Count; z++)
                        {
                            custContacts = listOfCustomerContacts[z];
                            if (custContacts.CustomerID == customerID)
                            {
                                row = new string[]{ custContacts.ID.ToString(), custContacts.Name,custContacts.Email,custContacts.ContactNumber,custContacts.CustomerID.ToString()};
                                var listItem = new ListViewItem(row);
                                
                                customerContactsListView.Items.Add(listItem);
                                
                            }
                         
                            
                        }
                       
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Exception occured in the View", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            GC.Collect();
        }
        //IView
        public event ViewHandler<IView> viewChanged;
        public void SetController(IController control)
        {
            controller = control;
        }






        private void CustomerContactsView_Load(object sender, EventArgs e)
        {
            controller.SelectAllCustomerContacts(CustomerID);
        }

        private void CustomerContactsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            businessModel.RemoveObserver(this);
        }
    }
}
