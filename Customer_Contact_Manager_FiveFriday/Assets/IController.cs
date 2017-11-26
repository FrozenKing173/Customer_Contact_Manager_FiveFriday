using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms


namespace Customer_Contact_Manager_FiveFriday.Assets
{
    public interface IController
    {
        //void incvalue();

        void AddCustomer(string Name, decimal Latitude, decimal Longitude);
        void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude);
        void DeleteCustomer(int ID);
        void SelectAllCustomers();
        void SelectCustomer(int ID);

        void AddCustomerContacts(string name, string email, string contactNumber, int customerID);
        void UpdateCustomerContacts(int id, string name, string email, string contactNumber, int customerID);
        void DeleteCustomerContacts(int id, int customerID);
        void SelectAllCustomerContacts(int customerID);

        void InitializeContactsView(IView custContactsView);
        //void StartApp();
    }
    public class Controller : IController
    {
        IView view;
        Assets.Models.IModel model;

        public Controller(IView v, Assets.Models.IModel m)
        {
            view = v;
            model = m;
            //view.SetController(this);
            //model.RegisterObserver((Assets.Models.IModelObserver)view);
            //view.viewChanged += new ViewHandler<IView>(this.View_Changed);
        }

        /*public void View_Changed(IView v, ViewEventArgs e)
        {
            //model.setvalue(e.value);
        }*/

        /*public void incvalue()
        {
           /model.increment();
        }*/


        /*public int AddCustomer() {
            return 1;
        }*/
        /*public void StartApp()
        {
            Application.Run()
        }*/
        public void AddCustomer(string Name, decimal Latitude, decimal Longitude){            
            model.AddCustomer(Name, Latitude, Longitude);
        }
        public void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude) {
            model.UpdateCustomer(ID, Name, Latitude, Longitude);           
        }
        public void DeleteCustomer(int ID) {
            model.DeleteCustomer(ID);
        }
        public void SelectAllCustomers(){
            model.SelectAllCustomers();           
        }
        public void SelectCustomer(int ID)
        {
            model.SelectCustomer(ID);
        }

        public void AddCustomerContacts(string name, string email, string contactNumber, int customerID) {
            model.AddCustomerContacts(name, email, contactNumber, customerID);
        }
        public void UpdateCustomerContacts(int id, string name, string email, string contactNumber, int customerID) {
            model.UpdateCustomerContacts(id, name, email, contactNumber, customerID);
        }
        public void DeleteCustomerContacts(int id, int customerID) {
            model.DeleteCustomerContacts(id, customerID);
        }
        public void SelectAllCustomerContacts(int customerID)
        {
            model.SelectAllCustomerContacts(customerID);
        }

        public void InitializeContactsView(IView custContactsView)
        {

            
            custContactsView.SetController(this);
            ((ContactsViewer)custContactsView).Show();

        }
    }
}
