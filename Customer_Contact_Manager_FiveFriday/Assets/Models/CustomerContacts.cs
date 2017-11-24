using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    class CustomerContacts
    {
        private int id;
        private string name;
        private string email;
        private string contactNumber;
        private int customerID;

        public CustomerContacts() { }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return name; }
            set { name = value; }
        }
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

    }
}
