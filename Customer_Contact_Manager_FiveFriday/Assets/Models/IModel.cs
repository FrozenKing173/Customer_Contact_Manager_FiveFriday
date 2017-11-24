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
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }
 
    public interface IModelObserver
    {
        void valueIncremented(IModel model, ModelEventArgs e);
    }
  
    public interface IModel
    {
        void AttachModel(IModelObserver imo);
        //void increment();
        //void setvalue(int v);

        void setCustomer(int id, string name, decimal latitude, decimal longitude);
        void setCustomerContact(int id, string name, string email, string contactNumber, int customerID);
        int AddCustomer();
        int UpdateCustomer();
        int DeleteCustomer();
        List<Customer> ReadCustomers();

        int AddCustomerContacts();
        int UpdateCustomerContacts();
        int DeleteCustomerContacts();
        List<CustomerContacts> ReadCustomerContacts();
    }
    public class Model : IModel
    {
        public event ModelHandler<Model> changed;
        Customer cust = null;
        CustomerContacts custContacts = null;
     
        public IncModel()
        {
            value = 0;
        }
     
        public void setvalue(int v)
        {
            value = v;
        }
    
        public void increment()
        {
            value++;
            changed.Invoke(this, new ModelEventArgs(value));
        }
     
        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<IncModel>(imo.valueIncremented);
        }








        public void setCustomer(int id, string name, decimal latitude, decimal longitude) { }
        public void setCustomerContact(int id, string name, string email, string contactNumber, int customerID) { }


        public int AddCustomer() {
            return 1;
        }
        public int UpdateCustomer() {
            return 1;
        }
        public int DeleteCustomer() {
            return 1;
        }
        public List<Customer> ReadCustomers() {
            return 1;
        }

        public int AddCustomerContacts() {
            return 1;
        }
        public int UpdateCustomerContacts() {
            return 1;
        }
        public int DeleteCustomerContacts() {
            return 1;
        }
        public List<CustomerContacts> ReadCustomerContacts() { }

    }
}
