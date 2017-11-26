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
            RegisterView();
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
                //Clear view data.
                if (listOfCustomerContacts.Count > 0)
                {
                    for (int x = customerContactsListView.Items.Count - 1; x >= 0; x--)
                    {
                        customerContactsListView.Items[x].Remove();                       
                    }
                }]
                //Fill view data.
                ListViewItem listItem = null;
                for (int z = 0; z < listOfCustomerContacts.Count; z++)
                {
                    custContacts = new CustomerContacts();
                    custContacts = listOfCustomerContacts[z];

                    if (custContacts.CustomerID == CustomerID)
                    {
                        listItem = new ListViewItem(custContacts.ID.ToString());
                        listItem.SubItems.Add(custContacts.Name);
                        listItem.SubItems.Add(custContacts.Email);
                        listItem.SubItems.Add(custContacts.ContactNumber);

                        customerContactsListView.Items.Add(listItem);
                    }
                }               
            }
            catch (Exception e)
            {
                MessageBox.Show("An excpetion occured in updating the Customer's contacts view.", "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            GC.Collect();
            ClearScreenInputs();


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
        public string GetBusinessViewState()
        {
            return CustomerID.ToString() + "_CustomerContacts";
        }

        //ContactsViewer
        private void CustomerContactsView_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
            lblCustomerName.Text = CustomerName;
            UseColour();
           
            controller.SelectAllCustomerContacts(CustomerID);
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
                        errorCode = 1;
                        MessageBox.Show("Kindly fill in the Name field.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    if (IsValidEmail(txtEmail.Text))
                    {
                        custContacts.Email = txtEmail.Text;
                    }
                    else
                    {
                        errorCode = 1;
                        MessageBox.Show("Sorry, that email is not valid.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    errorCode = 1;
                    MessageBox.Show("Kindly fill in valid fields.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                if (errorCode == 0)
                {
                    controller.UpdateCustomerContacts(custContacts.ID, custContacts.Name, custContacts.Email, custContacts.ContactNumber, custContacts.CustomerID);
                }
            }
            catch (Exception ex)
            {
                errorCode = 1;
                MessageBox.Show(ex.Message, "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
                int ID = int.Parse(lblID.Text.TrimStart(removeID));

                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtContactNumber.Text) && !string.IsNullOrEmpty(ID.ToString()) && lblID.Text.Length > 3)
                {
                    controller.DeleteCustomerContacts(ID, CustomerID);

                }
                else
                {
                    throw new Exception();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Please select a customer's contact before deleting.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerContacts custContacts = null;
            int errorCode = 0;
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtContactNumber.Text))
                {
                    custContacts = new CustomerContacts();
                    custContacts.ContactNumber = this.txtContactNumber.Text;
                    if (txtName.Text.Length < 3)
                    {
                        MessageBox.Show("Kindly fill in the Name field.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorCode = 1;
                    }
                    else
                    {
                        custContacts.Name = this.txtName.Text;
                    }
                    if (IsValidEmail(txtEmail.Text))
                    {
                        custContacts.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Kindly fill in a valid email address.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorCode = 1;

                    }



                    if (errorCode == 0)
                    {
                        controller.AddCustomerContacts(custContacts.Name, custContacts.Email, custContacts.ContactNumber, CustomerID);
                    }
                }
            }
            catch (Exception ex)
            {
                custContacts = null;
                MessageBox.Show(ex.Message, "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void CustomerContactsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread signOutThread = new Thread(new ThreadStart(UnRegisterView));

            Thread.Sleep(100);
        }
        private void customerContactsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (customerContactsListView.SelectedItems.Count > 0)
                {
                    ListViewItem item = customerContactsListView.SelectedItems[0];
                    lblID.Text = "ID " + item.SubItems[0].Text;
                    txtName.Text = item.SubItems[1].Text;
                    txtEmail.Text = item.SubItems[2].Text;
                    txtContactNumber.Text = item.SubItems[3].Text;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }    
        public void ClearScreenInputs()
        {
            txtEmail.Clear();
            txtContactNumber.Clear();
            lblID.Text = "ID: "; 
            txtName.Clear();


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
