using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer_Contact_Manager_FiveFriday.Assets.Models;
using System.Windows.Forms;


namespace Customer_Contact_Manager_FiveFriday.Assets
{
    /* The controller handles user input from the view and decides what to do with it depending on the request from the view.
    */ 
    public interface IController
    {
        //All the Customer view functions.
        void AddCustomer(string id, decimal latitude, decimal longitude);
        void UpdateCustomer(int id, string name, decimal latitude, decimal longitude);
        void DeleteCustomer(int id);
        void SelectAllCustomers();
        void InitializeContactsView(int id, string name);

        //All the customer's contacts view functions.
        void AddCustomerContacts(string name, string email, string contactNumber, int customerID);
        void UpdateCustomerContacts(int id, string name, string email, string contactNumber, int customerID);
        void DeleteCustomerContacts(int id, int customerID);
        void SelectAllCustomerContacts(int customerID);  
    }
    public class Controller : IController
    {
        IView view;
        IModel model;

        public Controller(IView v, IModel m)
        {
            view = v;
            model = m;

            ((CustomerView)view).SetController(this);
            view.RegisterView();

            Application.Run(((CustomerView)view));
        }
        //Customer controller options
        public void AddCustomer(string name, decimal latitude, decimal longitude){            
            model.AddCustomer(name, latitude, longitude);
        }
        public void UpdateCustomer(int id, string name, decimal latitude, decimal longitude) {
            model.UpdateCustomer(id, name, latitude, longitude);           
        }
        public void DeleteCustomer(int id) {
            model.DeleteCustomer(id);
        }
        public void SelectAllCustomers(){
            model.SelectAllCustomers();           
        }
        
        public void InitializeContactsView(int id, string name){
            view = new ContactsViewer(model, id, name);

            view.SetController(this);
            ((ContactsViewer)view).Show();
        }

        //Customer's contacts controller options
        public void AddCustomerContacts(string name, string email, string contactNumber, int customerID) {
            model.AddCustomerContacts(name, email, contactNumber, customerID);
        }
        public void UpdateCustomerContacts(int id, string name, string email, string contactNumber, int customerID) {
            model.UpdateCustomerContacts(id, name, email, contactNumber, customerID);
        }
        public void DeleteCustomerContacts(int id, int customerID) {
            model.DeleteCustomerContacts(id, customerID);
        }
        public void SelectAllCustomerContacts(int customerID){
            model.SelectAllCustomerContacts(customerID);
        }
   
       
    }
}
