using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Customer_Contact_Manager_FiveFriday.Assets.Models
{
    class AccessData
    {
       

        public AccessData() { }
        

        public List<Customer> SelectAllCustomers()
        {
            SqlConnection databaseConnection = null;
            SqlDataReader databaseReader = null;
            Customer cust = null;
            List<Customer> listOfCustomers = null;

            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_SelectAllCustomers", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.Parameters.Add(new SqlParameter("@CustomerID", custId));

                databaseReader = commandBuilder.ExecuteReader();

                listOfCustomers = new List<Customer>();
                while (databaseReader.Read())
                {
                    cust = new Customer();
                    cust.ID = int.Parse(databaseReader["ID"].ToString());
                    cust.Name = databaseReader["Name"].ToString();
                    cust.Latitude = Convert.ToDecimal(databaseReader["Latitude"].ToString());
                    cust.Longitude = Convert.ToDecimal(databaseReader["Longitude"].ToString());
                    listOfCustomers.Add(cust);
                    GC.Collect();
                }

                return listOfCustomers;
            }catch(Exception e)
            {
                listOfCustomers = null;
                MessageBox.Show(e.ToString(), "Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                if (databaseReader != null)
                {
                    databaseReader.Close();
                }
            }
            return listOfCustomers;
        }
    }
}
