using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    /* I've made the business model so that it updates an individual view(IModelObserver) depending on the business objective regarding a specific view.
    */ 
    public interface IModelObserver
    {
        void UpdateBusinessView(Dictionary<string, IList> updates);
    }
  
    public interface IModel
    {       
        //Register BusinessViews as IModelObserver
        void RegisterObserver(IModelObserver modelObserver, string ID);
        void RemoveObserver(IModelObserver modelObserver, string ID);
        void NotifyObservers();     

        //Handle customer data.
        void AddCustomer(string Name, decimal Latitude, decimal Longitude);
        void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude);
        void DeleteCustomer(int ID);
        void SelectAllCustomers();        

        //Handle customer's contacts data.
        void AddCustomerContacts(string name, string email, string contactNumber, int customerID);
        void UpdateCustomerContacts(int ID, string name, string email, string constactNumber, int customerID);
        void DeleteCustomerContacts(int ID, int customerID);
        void SelectAllCustomerContacts(int customerID);

        
    }
    public class Model : IModel
    {
        
        List<BusinessObserver> businessViews = null;
        Dictionary<string, IList> businessData = null;
                
        private string businessViewState;

        AccessData acData = null;        
        
        public Model() {
            businessViews = new List<BusinessObserver>();
            businessData = new Dictionary<string, IList>();            
        }            
            
        public string BusinessViewState
        {
            get { return businessViewState; }
            set { businessViewState = value;}
        }
        //Register BusinessViews as IModelObserver
        public void RegisterObserver(IModelObserver observer, string ID)
        {
            BusinessObserver registerBusinessView = new BusinessObserver(ID, observer);
            businessViews.Add(registerBusinessView);
            string[] generateID = ID.Split('_');
            if(generateID[1] == "Customer")
            {
                if (businessData.ContainsKey(ID))
                {
                    List<Customer> createList = new List<Customer>();
                    businessData[ID] = createList;
                }
                else
                {
                    List<Customer> createList = new List<Customer>();
                    businessData.Add(ID, createList);
                }
                
            }else if(generateID[1] == "CustomerContacts")
            {
                if (businessData.ContainsKey(ID))
                {
                    List<CustomerContacts> createList = new List<CustomerContacts>();
                    businessData[ID] = createList;
                }
                else
                {
                    List<CustomerContacts> createList = new List<CustomerContacts>();
                    businessData.Add(ID, createList);
                }
               
            }
          
        }
        public void RemoveObserver(IModelObserver observer, string ID)
        {
            BusinessObserver removeBusinessView = new BusinessObserver(ID, observer);
            businessViews.Remove(removeBusinessView);
            businessData.Remove(ID);
           
        }
        public void NotifyObservers()
        {
           
            foreach(BusinessObserver businessView in businessViews)
            {
                
                if(businessView.ID == BusinessViewState.ToString())
                {
                    businessView.VIEW.UpdateBusinessView(businessData);
                }
               
            }
           
        }

        //Handle customer data.
        public void AddCustomer(string Name, decimal Latitude, decimal Longitude) {
            Customer cust = new Customer();
            cust.Name = Name; cust.Latitude = Latitude; cust.Longitude = Longitude;

            acData = AccessData.Instance;      
            acData.AddCustomer(cust);

            SelectAllCustomers();
        }
        public void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude) {
            Customer cust = new Customer();
            cust.ID = ID; cust.Name = Name; cust.Latitude = Latitude; cust.Longitude = Longitude;

            acData = AccessData.Instance;            
            acData.UpdateCustomer(cust);

            SelectAllCustomers();
        }
        public void DeleteCustomer(int ID) {
            acData = AccessData.Instance;            
            acData.DeleteCustomer(ID);

            SelectAllCustomers();
        }
        public void SelectAllCustomers() {
            BusinessViewState = "None_Customer";

            acData = AccessData.Instance;
            List<Customer> listOfCustomers = acData.SelectAllCustomers();

            businessData[businessViewState] = listOfCustomers;
            
            NotifyObservers();
        }

        //Handle customer's contacts data.
        public void AddCustomerContacts(string name, string email, string contactNumber, int customerID) {
            CustomerContacts custContacts = new CustomerContacts();
            custContacts.Name = name; custContacts.Email = email; custContacts.ContactNumber = contactNumber; custContacts.CustomerID = customerID;

            acData = AccessData.Instance;
            acData.AddCustomerContacts(custContacts);

            SelectAllCustomerContacts(customerID);
        }
        public void UpdateCustomerContacts(int id, string name, string email, string contactNumber, int customerID) {
            CustomerContacts custContacts = new CustomerContacts();
            custContacts.ID = id; custContacts.Name = name; custContacts.Email = email; custContacts.ContactNumber = contactNumber; custContacts.CustomerID = customerID;

            acData = AccessData.Instance;
            acData.UpdateCustomerContacts(custContacts);

            SelectAllCustomerContacts(custContacts.CustomerID);
        }
        public void DeleteCustomerContacts(int id, int customerID) {            
            CustomerContacts custContacts = new CustomerContacts();
            custContacts.ID = id; custContacts.CustomerID = customerID;

            acData = AccessData.Instance;
            acData.DeleteCustomerContacts(custContacts);

            SelectAllCustomerContacts(custContacts.CustomerID);
        }
        public void SelectAllCustomerContacts(int customerID) {                                  
            acData = AccessData.Instance;
            List<CustomerContacts> listOfCustomerContacts = acData.SelectAllCustomerContacts(customerID);

            string state = customerID.ToString() + "_CustomerContacts";
            BusinessViewState = state;
            businessData[BusinessViewState] = listOfCustomerContacts;
            
            NotifyObservers();
        }

       
    }
}