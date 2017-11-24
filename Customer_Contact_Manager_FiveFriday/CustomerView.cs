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
    public partial class CustomerView : Form, IView, Assets.Models.IModelObserver
    {
        IController controller;
        IModel businessModel;
        public CustomerView(IModel model)
        {
            businessModel = model;
            InitializeComponent();
        }

        //IModelObserverable
        public void UpdateObserver(Assets.Models.IModel model, Assets.Models.ModelEventArgs modelEvents)
        {
            customerDataGridView.Rows.Clear();
            Customer cust = null;
            try
            {
                object obj = modelEvents.objectValue;
                bool isCustomerList = obj?.GetType() == typeof(List<Customer>);

                if (isCustomerList){
                    List<Customer> listOfCustomers = (List<Customer>)modelEvents.objectValue;
                    if (listOfCustomers != null) {

                        for (int z = 0; z < listOfCustomers.Count; z++)
                        {
                            cust = listOfCustomers[z];
                            customerDataGridView.Rows.Add(cust.ID, cust.Name, cust.Latitude, cust.Longitude);
                        }

                    }
                }
            }catch(Exception e)
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
       





        private void Main_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
            logo.Image = Customer_Contact_Manager_FiveFriday.Properties.Resources.logomark_90px;
            controller.SelectAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int errorCode = 1;
            Assets.Models.Customer cust = new Assets.Models.Customer();
            char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };

            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("Kindly fill in the Name entry.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorCode = 0;

            }
            else
            {
                cust.Name = txtName.Text;
            }
            try
            {
               
                cust.ID = int.Parse(lblID.Text.TrimStart(removeID));                
            }catch(Exception ex)
            {
                errorCode = 0;
                MessageBox.Show(ex.ToString(), "Exception occured in the View being updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            try
            {
                cust.Latitude = Convert.ToDecimal(txtLatitude.Text);
                cust.Longitude = Convert.ToDecimal(txtLongitude.Text);
            }
            catch (Exception ex)
            {
                errorCode = 0;
                MessageBox.Show("Please ensure a valid decimal number is entered.", "Exception occured in the View being updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (errorCode == 1)
            {
                controller.UpdateCustomer(cust.ID, cust.Name, cust.Latitude, cust.Longitude);
               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
            int ID = int.Parse(lblID.Text.TrimStart(removeID));
            controller.DeleteCustomer(ID);
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = customerDataGridView.SelectedRows[1];
           
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtName.Text = customerDataGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            txtLatitude.Text = customerDataGridView.Rows[e.RowIndex].Cells["Latitude"].Value.ToString();
            txtLongitude.Text = customerDataGridView.Rows[e.RowIndex].Cells["Longitude"].Value.ToString();

            lblID.Text = "ID: " + customerDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            int errorCode = 1;
            if(txtName.Text.Length < 3)
            {
                MessageBox.Show("Kindly fill in the Name entry.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorCode = 0;

            }
            else
            {
                cust.Name = txtName.Text;
            }

            try
            {
                cust.Latitude = Convert.ToDecimal(txtLatitude.Text);
                cust.Longitude = Convert.ToDecimal(txtLongitude.Text);
            }catch(Exception ex)
            {
                errorCode = 0;
                MessageBox.Show("Kindly ensure that the Latitude and Longitude fields are decimal.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (errorCode == 1)
            {
                controller.AddCustomer(cust.Name, cust.Latitude, cust.Longitude);
            }

        }

        private void btnCustomerContacts_Click(object sender, EventArgs e)
        {
            ContactsView custContactsView = null;
            try
            {
                char[] removeID = new char[] { 'I', 'D', 'i', 'd', ':', ' ' };
                int ID = int.Parse(lblID.Text.TrimStart(removeID));
                custContactsView = new ContactsView(businessModel);
                businessModel.RegisterObserver(custContactsView);

                custContactsView.CustomerID = ID;
                custContactsView.Show();
                
                
            }catch(Exception ex)
            {
                custContactsView = null;
                MessageBox.Show("Please select a customer.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
