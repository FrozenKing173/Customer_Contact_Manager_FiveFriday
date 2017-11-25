using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    //public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
  
    /*public class ModelEventArgs : EventArgs
    {
        public object objectValue;
        public ModelEventArgs(object value)
        {
            objectValue = value;
        }
        

    }*/
 
    public interface IModelObserver
    {
        //void valueIncremented(IModel model, ModelEventArgs e);

        //void UpdateObserver(IModel model, ModelEventArgs modelEvents);
        void UpdateBusinessView(Dictionary<string, IList> updates);
        string GetBusinessViewState();
    }
  
    public interface IModel
    {
        //void Attach(IModelObserver imo);
        //void increment();
        //void setvalue(int v);

        void RegisterObserver(IModelObserver modelObserver, string ID);
        void RemoveObserver(IModelObserver modelObserver, string ID);
        void NotifyObservers();

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

        //void SetBusinessViewState(string businessViewState);
    }
    public class Model : IModel
    {
        //public event ModelHandler<Model> changed = null;
        List<BusinessObserver> businessViews = null;
        Dictionary<string, IList> businessData = null;
        
        //List<string> businessViewIDs = null;
        private string businessViewState;

        AccessData acData = null;
        //IView currentView = null;
        
        public Model() {
            businessViews = new List<BusinessObserver>();
            businessData = new Dictionary<string, IList>();
            //businessViewIDs = new List<string>();
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
            
        public string BusinessViewState
        {
            get { return businessViewState; }
            set { businessViewState = value;}
        }
       
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
            //businessViewIDs.Add(ID);

            //currentView = (IView)MainView;
            //changed += new ModelHandler<Model>(observer.UpdateObserver);
        }
        public void RemoveObserver(IModelObserver observer, string ID)
        {
            BusinessObserver removeBusinessView = new BusinessObserver(ID, observer);
            businessViews.Remove(removeBusinessView);
            businessData.Remove(ID);
            //businessViewIDs.Remove(ID);
        }
        public void NotifyObservers()
        {
            string viewState = "";
            string businessViewState = "";
            foreach(BusinessObserver businessView in businessViews)
            {
                
                if(businessView.ID == BusinessViewState.ToString())
                {
                    businessView.VIEW.UpdateBusinessView(businessData);
                }
               
            }
            //changed.Invoke(this, modelEvent);
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
            BusinessViewState = "None_Customer";
            acData = AccessData.Instance;
            List<Customer> listOfCustomers = acData.SelectAllCustomers();

            businessData[businessViewState] = listOfCustomers;
            //changed.Invoke(this, new ModelEventArgs(listOfCustomers));
            NotifyObservers();
        }

        public void AddCustomerContacts(string name, string email, string contactNumber, int customerID) {
            acData = AccessData.Instance;
            
            CustomerContacts custContacts = new CustomerContacts();
            custContacts.Name = name; custContacts.Email = email; custContacts.ContactNumber = contactNumber; custContacts.CustomerID = customerID;
            acData.AddCustomerContacts(custContacts);
            SelectAllCustomerContacts(customerID);
        }
        public void UpdateCustomerContacts() {
            acData = AccessData.Instance;
            
        }
        public void DeleteCustomerContacts() {
            acData = AccessData.Instance;
            
        }
        public void SelectAllCustomerContacts(int customerID) {
            acData = AccessData.Instance;
            string state = customerID.ToString() + "_CustomerContacts";
            BusinessViewState = state;
            List<CustomerContacts> listOfCustomerContacts = acData.SelectAllCustomerContacts(customerID);
            businessData[BusinessViewState] = listOfCustomerContacts;
            //NotifyObservers(new ModelEventArgs(listOfCustomerContacts));
            NotifyObservers();
        }

       
    }
}
