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
using System.Collections;
using System.Threading;

namespace Customer_Contact_Manager_FiveFriday
{
    public partial class ContactsView : Form, IView, IModelObserver
    {
        IController controller;
        IModel businessModel;
        private int customerID;       
        public ContactsView(IModel model, int ID)
        {
            customerID = ID;
                
            businessModel = model;                       
            InitializeComponent();
        }
        
        public int CustomerID
        {
            get{ return customerID; }
            set{ customerID = value; }
        }
        
        

        //IModelObserverable
        public void UpdateBusinessView(Dictionary<string, IList> updates)
        {        
            CustomerContacts custContacts = null;

            try
            {
                
                List<CustomerContacts> listOfCustomerContacts = (List<CustomerContacts>)updates[GetBusinessViewState()];
              
                if (listOfCustomerContacts.Count > 0)
                {
                    for (int x = customerContactsListView.Items.Count - 1; x >= 0; x--)
                    {
                        customerContactsListView.Items[x].Remove();
                        //customerContactsListView.Items.Remove(customerContactsListView.SelectedItems[0]);
                    }

                    
                    ListViewItem listItem = null;
                    for (int z = 0; z < listOfCustomerContacts.Count; z++)
                    {
                        custContacts = listOfCustomerContacts[z];
                        if (custContacts.CustomerID == customerID)
                        {
                          
                            listItem = new ListViewItem(custContacts.ID.ToString());                                                                                   
                            listItem.SubItems.Add(custContacts.Name);
                            listItem.SubItems.Add(custContacts.Email);
                            listItem.SubItems.Add(custContacts.ContactNumber);
                            listItem.SubItems.Add(custContacts.CustomerID.ToString());

                            customerContactsListView.Items.Add(listItem);

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
        public string GetBusinessViewState()
        {
            return CustomerID.ToString() + "_CustomerContacts";
        }
        //IView
        //public event ViewHandler<IView> viewChanged;
        public void SetController(IController control)
        {
            controller = control;
        }
        public void RegisterView()
        {
            businessModel.RegisterObserver(this, GetBusinessViewState());
        }
        public void UnRegisterView()
        {
            businessModel.RemoveObserver(this, GetBusinessViewState());
        }        
        
        





        private void CustomerContactsView_Load(object sender, EventArgs e)
        {
            controller.SelectAllCustomerContacts(CustomerID);
        }

        private void CustomerContactsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread signOutThread = new Thread(new ThreadStart(UnRegisterView));

            Thread.Sleep(100);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerContacts custContacts = null;
            int errorCode = 1;
            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("Kindly fill in the Name entry.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorCode = 0;

            }
            else
            {
                custContacts = new CustomerContacts();
                custContacts.Name = this.txtName.Text;
            }

            try
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    custContacts.Email = this.txtEmail.Text;
                }
                else
                {
                    throw new Exception();
                    
                }

                custContacts.ContactNumber = this.txtContactNumber.Text;
            }
            catch (Exception ex)
            {
                errorCode = 0;
                MessageBox.Show("Kindly ensure all the fields are entered in correct.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (errorCode == 1)
            {
                controller.AddCustomerContacts(custContacts.Name, custContacts.Email, custContacts.ContactNumber, CustomerID);
            }
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void customerContactsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = customerContactsListView.SelectedItems[0].SubItems["CustomerContactsName"].Text;
            txtEmail.Text = customerContactsListView.SelectedItems[0].SubItems["CustomerContactsEmail"].Text;
            txtContactNumber.Text = customerContactsListView.SelectedItems[0].SubItems["CustomerContactsNumber"].Text;
        }
    }
}
