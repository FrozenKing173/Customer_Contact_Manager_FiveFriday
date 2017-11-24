using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Customer_Contact_Manager_FiveFriday.Assets
{
    public interface IController
    {
        //void incvalue();

        void AddCustomer(string Name, decimal Latitude, decimal Longitude);
        void UpdateCustomer(int ID, string Name, decimal Latitude, decimal Longitude);
        void DeleteCustomer(int ID);
        void SelectAllCustomers();
       
        int UpdateCustomerContacts();
        int DeleteCustomerContacts();
        int SelectAllCustomerContacts();
    }
    public class Controller : IController
    {
        IView view;
        Assets.Models.IModel model;

        public Controller(IView v, Assets.Models.IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.RegisterObserver((Assets.Models.IModelObserver)view);
            view.viewChanged += new ViewHandler<IView>(this.View_Changed);
        }

        public void View_Changed(IView v, ViewEventArgs e)
        {
            //model.setvalue(e.value);
        }

        /*public void incvalue()
        {
           /model.increment();
        }*/


        /*public int AddCustomer() {
            return 1;
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

        /*public int AddCustomerContacts() {
            return 1;
        }*/
        public int UpdateCustomerContacts() {
            return 1;
        }
        public int DeleteCustomerContacts() {
            return 1;
        }
        public int SelectAllCustomerContacts()
        {
            return 1;
        }



    }
}
