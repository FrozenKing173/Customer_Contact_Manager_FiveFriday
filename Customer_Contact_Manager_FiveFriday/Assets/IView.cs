using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Contact_Manager_FiveFriday.Assets
{

    /*public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
   
    public class ViewEventArgs : EventArgs
    {
        public int value;
        public ViewEventArgs(int v) { value = v; }
    }*/
  
    public interface IView
    {
        //event ViewHandler<IView> viewChanged;
        void SetController(IController controller);
        void RegisterView();
        void UnRegisterView();

        string GetBusinessViewState();
       
    }
}
