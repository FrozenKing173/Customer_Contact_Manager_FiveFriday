using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
  
    public class ModelEventArgs : EventArgs
    {
        public object objectValue;
        public ModelEventArgs(object value)
        {
            objectValue = value;
        }
        

    }
 
    public interface IModelObserver
    {
        //void valueIncremented(IModel model, ModelEventArgs e);

        void UpdateObserver(IModel model, ModelEventArgs modelEvents);
    }
  
    public interface IModel
    {
        //void Attach(IModelObserver imo);
        //void increment();
        //void setvalue(int v);

        void RegisterObserver(IModelObserver modelObserver);
        void RemoveObserver(IModelObserver modelObserver);
        void NotifyObservers(ModelEventArgs modelEvent);

        //void setCustomer(int id, string name, decimal latitude, decimal longitude);
       // void setCustomerContact(int id, string name, string email, string contactNumber, int customerID);

        void AddCustomer(string Name, decimal Latitude, decimal Longitude);
        void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude);
        void DeleteCustomer(int ID);
        void SelectAllCustomers();

        void AddCustomerContacts(string name, string email, string contactNumber, int customerID);
        void UpdateCustomerContacts();
        void DeleteCustomerContacts();
        void SelectAllCustomerContacts(int customerID);
    }
    public class Model : IModel
    {
        public event ModelHandler<Model> changed = null;
        List<IModelObserver> modelObservers = null;
        AccessData acData = null;
        //IView currentView = null;
        
        public Model() {
            modelObservers = new List<IModelObserver>();
        }
     
        /*public IncModel()
        {
            value = 0;
        }*/
     
        /*public void setvalue(int v)
        {
            value = v;
        }*/
    
        /*public void increment()
        {
            value++;
            changed.Invoke(this, new ModelEventArgs(value));
        }*/
     
        /*public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<IModel>(imo.valueIncremented);
        }*/
            
        public void RegisterObserver(IModelObserver observer)
        {
            modelObservers.Add(observer);
            //currentView = (IView)MainView;
            changed += new ModelHandler<Model>(observer.UpdateObserver);
        }
        public void RemoveObserver(IModelObserver observer)
        {
            modelObservers.Remove(observer);
        }
        public void NotifyObservers(ModelEventArgs modelEvent)
        {
            changed.Invoke(this, modelEvent);
        }

        //public void setCustomer(int id, string name, decimal latitude, decimal longitude) { }
        //public void setCustomerContact(int id, string name, string email, string contactNumber, int customerID) { }


        public void AddCustomer(string Name, decimal Latitude, decimal Longitude) {
            acData = AccessData.Instance;

            Customer cust = new Customer();
            cust.Name = Name; cust.Latitude = Latitude; cust.Longitude = Longitude;
            acData.AddCustomer(cust);
            SelectAllCustomers();
        }
        public void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude) {
            acData = AccessData.Instance;

            Customer cust = new Customer();
            cust.ID = ID; cust.Name = Name; cust.Latitude = Latitude; cust.Longitude = Longitude;
            acData.UpdateCustomer(cust);

            SelectAllCustomers();
        }
        public void DeleteCustomer(int ID) {
            acData = AccessData.Instance;
            acData.DeleteCustomer(ID);

            SelectAllCustomers();
        }
        public void SelectAllCustomers() {
            acData = AccessData.Instance;
            List<Customer> listOfCustomers = acData.SelectAllCustomers();
            changed.Invoke(this, new ModelEventArgs(listOfCustomers));
        }

        public void AddCustomerContacts(string name, string email, string contactNumber, int customerID) {
            acData = AccessData.Instance;

            CustomerContacts custContacts = new CustomerContacts();
            custContacts.Name = name; custContacts.Email = email; custContacts.ContactNumber = contactNumber; custContacts.CustomerID = customerID;
            acData.AddCustomerContacts(custContacts);
            SelectAllCustomerContacts(customerID);
        }
        public void UpdateCustomerContacts() {
            
        }
        public void DeleteCustomerContacts() {
            
        }
        public void SelectAllCustomerContacts(int customerID) {
            acData = AccessData.Instance;
            List<CustomerContacts> listOfCustomerContacts = acData.SelectAllCustomerContacts(customerID);
            NotifyObservers(new ModelEventArgs(listOfCustomerContacts));
        }

    }
}
