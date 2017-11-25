using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    class BusinessObserver
    {
        public string ID { get; set; }
        public IModelObserver VIEW { get; set; }

        public BusinessObserver(string id, IModelObserver view)
        {
            ID = id;
            VIEW = view;
        }
    }
}
