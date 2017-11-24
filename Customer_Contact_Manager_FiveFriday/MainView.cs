using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Contact_Manager_FiveFriday
{
    public partial class MainView : Form, IView
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            logo.Image = Customer_Contact_Manager_FiveFriday.Properties.Resources.logomark_90px;
            

        }
    }
}
