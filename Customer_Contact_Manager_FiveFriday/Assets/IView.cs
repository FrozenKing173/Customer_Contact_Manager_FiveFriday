using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets
{    
    public interface IView
    {        
        //View registers the controller.
        void SetController(IController controller);
        //View registers as an observer on the model.
        void RegisterView();
        void UnRegisterView();
        //a method for getting the View's ID state
        string GetBusinessViewState();//
       
    }
}
