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

        int AddCustomer();
        int UpdateCustomer();
        int DeleteCustomer();
        List<Customer> ReadCustomers();

        int AddCustomerContacts();
        int UpdateCustomerContacts();
        int DeleteCustomerContacts();
        List<CustomerContacts> ReadCustomerContacts();
    }
    public class Controller : IController
    {
        IView view;
        IModel model;

        public Controller(IView v, IModel m)
        {
            view = v;
            model = m;
            view.setController(this);
            model.attach((IModelObserver)view);
            view.changed += new ViewHandler<IView>(this.view_changed);
        }

        public void view_changed(IView v, ViewEventArgs e)
        {
            model.setvalue(e.value);
        }

        public void incvalue()
        {
            model.increment();
        }


        public int AddCustomer() {
            return 1;
        }
        public int UpdateCustomer() {
            return 1;
        }
        public int DeleteCustomer() {
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



    }
}
