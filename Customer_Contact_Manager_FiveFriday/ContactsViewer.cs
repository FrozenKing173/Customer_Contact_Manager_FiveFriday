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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Customer_Contact_Manager_FiveFriday
{
    public partial class ContactsViewer : Form, IView, IModelObserver
    {
        IController controller;
        IModel businessModel;
        private int customerID;
        private string customerName;
        public ContactsViewer(IModel model, int ID, string name)
        {
            CustomerID = ID;
            CustomerName = name;
            businessModel = model;
            InitializeComponent();
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
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

                            customerContactsListView.Items.Add(listItem);

                        }


                    }

                }
                ClearScreenInputs();
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





        public void UseColour()
        {
            string blue = "#419fd6";
            string yellow = "#fcab10";
            string red = "#ef2d56";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(blue);
            this.btnAdd.BackColor = myColor;
            myColor = System.Drawing.ColorTranslator.FromHtml(yellow);
            this.btnUpdate.BackColor = myColor;
            myColor = System.Drawing.ColorTranslator.FromHtml(red);
            this.btnDelete.BackColor = myColor;
        }

        private void CustomerContactsView_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
            lblCustomerName.Text = CustomerName;
            UseColour();

            //form1.BackColor = myColor;
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
            if (txtName.Text.Length < 3 && string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Kindly fill in the Name entry.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorCode = 0;

            }
            else
            {
                custContacts = new CustomerContacts();
                custContacts.Name = this.txtName.Text;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtContactNumber.Text))
                {


                    if (IsValidEmail(txtEmail.Text))
                    {
                        custContacts.Email = txtEmail.Text;
                    }
                    else
                    {
                        throw new Exception();

                    }

                    custContacts.ContactNumber = this.txtContactNumber.Text;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                errorCode = 0;
                MessageBox.Show("Kindly ensure all the fields are entered in correct.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (errorCode == 1)
            {
                controller.AddCustomerContacts(custContacts.Name, custContacts.Email, custContacts.ContactNumber, CustomerID);

                txtEmail.Clear();
                txtContactNumber.Clear();
                txtName.Clear();
            }
        }        

        private void customerContactsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerContactsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = customerContactsListView.SelectedItems[0];
                lblID.Text = "ID " + item.SubItems[0].Text;
                txtName.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtContactNumber.Text = item.SubItems[3].Text;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int errorCode = 0;
            CustomerContacts custContacts = null;
            char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtContactNumber.Text))
                {


                    custContacts = new CustomerContacts();
                    custContacts.CustomerID = CustomerID;
                    custContacts.ID = int.Parse(lblID.Text.TrimStart(removeID));
                    custContacts.ContactNumber = txtContactNumber.Text;
                    if (txtName.Text.Length > 2)
                    {
                        custContacts.Name = txtName.Text;
                    }
                    else
                    {
                        throw new Exception();
                    }


                    if (IsValidEmail(txtEmail.Text))
                    {
                        custContacts.Email = txtEmail.Text;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                errorCode = 1;
                MessageBox.Show("Kindly ensure that all the fields are valid.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (errorCode == 0)
            {
                controller.UpdateCustomerContacts(custContacts.ID, custContacts.Name, custContacts.Email, custContacts.ContactNumber, custContacts.CustomerID);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
            int ID = int.Parse(lblID.Text.TrimStart(removeID));

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtContactNumber.Text) && !string.IsNullOrEmpty(ID.ToString()) && lblID.Text.Length > 3)
            {
                controller.DeleteCustomerContacts(ID, CustomerID);

            }
            else
            {
                MessageBox.Show("Please select a contant.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void ClearScreenInputs()
        {
            txtEmail.Clear();
            txtContactNumber.Clear();
            txtName.Clear();

        }
        public bool IsValidEmail(string email)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$");
                Match matchEmail = regex.Match(email);
                if (matchEmail.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
