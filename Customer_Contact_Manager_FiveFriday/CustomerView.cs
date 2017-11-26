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
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Customer_Contact_Manager_FiveFriday
{
    public partial class CustomerView : Form, IView, IModelObserver
    {
        IController controller;
        IModel businessModel;        
        public CustomerView(IModel model)
        {
            businessModel = model;            
            InitializeComponent();
        }
        
        //IModelObserverable
        public void UpdateBusinessView(Dictionary<string, IList> updates)
        {            
            Customer cust = null;
            try
            {
                List<Customer> listOfCustomers = (List<Customer>)updates["None_Customer"];                
                //Clear view data.
                if (customerDataGridView.Rows.Count > 0){
                    customerDataGridView.Rows.Clear();                                
                }
                //Filld view data.
                if (listOfCustomers.Count > 0)
                {
                    for (int z = 0; z < listOfCustomers.Count; z++)
                    {
                        cust = new Customer();
                        cust = listOfCustomers[z];
                        customerDataGridView.Rows.Add(cust.ID, cust.Name, cust.Latitude, cust.Longitude);
                    }
                }
            }
            catch(Exception e)
            {                
                MessageBox.Show("An excpetion occured in updating the Customer view.", "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
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
            return "None_Customer";
        }

        //CustomerView
        private string GetBusinessContactsViewState()
        {
            char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
            int ID = int.Parse(lblID.Text.TrimStart(removeID));
            return  ID.ToString() + "_CustomerContacts";
        }        
        private void Main_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
            UseColour();            
            controller.SelectAllCustomers();

           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int errorCode = 0;
            Customer cust = null;
            char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };

            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtLatitude.Text) && !string.IsNullOrEmpty(txtLongitude.Text))
                {
                    cust = new Customer();                    

                    if (lblID.Text.Length > 4)
                    {
                        cust.ID = int.Parse(lblID.Text.TrimStart(removeID));
                    }
                    else
                    {
                        errorCode = 1;
                        MessageBox.Show("Kindly select a customer's contacts to be updated.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (txtName.Text.Length < 3)
                    {
                        MessageBox.Show("Kindly fill in the Name field.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorCode = 1;
                    }
                    else
                    {
                        cust.Name = txtName.Text;
                    }
                    decimal resultLatitude;
                    decimal resultLongitude;
                    if (decimal.TryParse(txtLatitude.Text, out resultLatitude) && decimal.TryParse(txtLongitude.Text, out resultLongitude))
                    {
                        cust.Latitude = resultLatitude;
                        cust.Longitude = resultLongitude;
                    }
                    else
                    {
                        MessageBox.Show("Kindly fill in a valid decimal Latitude and Longitude.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorCode = 1;
                    }

                }
                else
                {
                    errorCode = 1;
                    MessageBox.Show("Kindly fill in valid fields.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                if (errorCode == 0)
                {
                    controller.UpdateCustomer(cust.ID, cust.Name, cust.Latitude, cust.Longitude);

                }
            }
            catch(Exception ex)
            {
                cust = null;
                MessageBox.Show(ex.Message, "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { 
                char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
                int ID = int.Parse(lblID.Text.TrimStart(removeID));
                controller.DeleteCustomer(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a customer before deleting.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer cust = null;            
            int errorCode = 0;
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtLatitude.Text) && !string.IsNullOrEmpty(txtLongitude.Text))
                {
                    cust = new Customer();

                    if (txtName.Text.Length < 3)
                    {
                        MessageBox.Show("Kindly fill in the Name field.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorCode = 1;

                    }
                    else
                    {
                        cust.Name = txtName.Text;
                    }
                    decimal resultLatitude;
                    decimal resultLongitude;
                    if (decimal.TryParse(txtLatitude.Text, out resultLatitude) && decimal.TryParse(txtLongitude.Text, out resultLongitude))
                    {
                        cust.Latitude = resultLatitude;
                        cust.Longitude = resultLongitude;
                    }
                    else
                    {
                        MessageBox.Show("Kindly fill in a valid decimal Latitude and Longitude.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorCode = 1;
                    }
                }
                else
                {
                    errorCode = 1;
                    MessageBox.Show("Kindly fill in valid fields.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                if (errorCode == 0)
                {
                    controller.AddCustomer(cust.Name, cust.Latitude, cust.Longitude);
                }
            }catch(Exception ex)
            {
                cust = null;
                MessageBox.Show(ex.Message, "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCustomerContacts_Click(object sender, EventArgs e)
        {           
            try
            {
                char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
                int ID = int.Parse(lblID.Text.TrimStart(removeID));
                if (string.IsNullOrEmpty(txtName.Text)) throw new Exception();                
                
                controller.InitializeContactsView(ID, txtName.Text); 
            }
            catch(Exception ex)
            {               
                MessageBox.Show("Please select a customer.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }
        private void CustomerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread signOutThread = new Thread(new ThreadStart(UnRegisterView));

            Thread.Sleep(50);
        }
        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = customerDataGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                txtLatitude.Text = customerDataGridView.Rows[e.RowIndex].Cells["Latitude"].Value.ToString();
                txtLongitude.Text = customerDataGridView.Rows[e.RowIndex].Cells["Longitude"].Value.ToString();
                lblID.Text = "ID: " + customerDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal-error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ClearScreenInputs()
        {
            txtLatitude.Clear();
            txtLongitude.Clear();
            lblID.Text = "ID: ";
            txtName.Clear();

        }
        private void UseColour()
        {
            string blue = "#419fd6";
            string yellow = "#fcab10";
            string red = "#ef2d56";
            string grey = "#999999";
            string purple = "#443c6e";

            Color myColor = System.Drawing.ColorTranslator.FromHtml(blue);
            this.btnAdd.BackColor = myColor;
            myColor = System.Drawing.ColorTranslator.FromHtml(yellow);
            this.btnUpdate.BackColor = myColor;
            myColor = System.Drawing.ColorTranslator.FromHtml(red);
            this.btnDelete.BackColor = myColor;
            myColor = System.Drawing.ColorTranslator.FromHtml(purple);
            this.btnCustomerContacts.BackColor = myColor;

            myColor = System.Drawing.ColorTranslator.FromHtml(grey);
            this.customerDataGridView.BackgroundColor = myColor;

        }
    }
}
