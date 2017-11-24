using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    class Customer
    {
        private int id;
        private string name;
        private decimal latitude;
        private decimal longitude;
        public Customer() { }

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
        public decimal Latitude
        {
            get { return latitude;}
            set { latitude = value;}
        }
        public decimal Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

    }
}
