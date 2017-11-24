using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer_Contact_Manager_FiveFriday.Assets.Models;

namespace Customer_Contact_Manager_FiveFriday.Assets
{
    public interface IController
    {
        //void incvalue();

      
        int UpdateCustomer();
        int DeleteCustomer();
        int SelectAllCustomers();
       
        int UpdateCustomerContacts();
        int DeleteCustomerContacts();
        int SelectAllCustomerContacts();
    }
    public class Controller : IController
    {
        IView view;
        IModel model;

        public Controller(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.RegisterObserver((IModelObserver)view);
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
        public int UpdateCustomer() {
            return 1;
        }
        public int DeleteCustomer() {
            return 1;
        }
        public int SelectAllCustomers()
        {
            model.SelectAllCustomers();
            return 1;
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
