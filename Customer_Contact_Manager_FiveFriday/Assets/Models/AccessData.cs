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
        private static AccessData instance = null;
        private static readonly object locker = new object();

        private AccessData() { }

        public static AccessData Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new AccessData();
                    }
                    return instance;
                }
            }
        }

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
                    
                }

                return listOfCustomers;
            }catch(Exception e)
            {
                listOfCustomers = null;
                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                GC.Collect();
            }
            return listOfCustomers;
        }
        public Customer SelectCustomer(int ID)
        {
            SqlConnection databaseConnection = null;
            SqlDataReader databaseReader = null;
            Customer cust = null;
            

            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_SelectAllCustomers", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;
                commandBuilder.Parameters.Add(new SqlParameter("@ID", ID));

                databaseReader = commandBuilder.ExecuteReader();

                
                while (databaseReader.Read())
                {
                    cust = new Customer();
                    cust.ID = int.Parse(databaseReader["ID"].ToString());
                    cust.Name = databaseReader["Name"].ToString();
                    cust.Latitude = Convert.ToDecimal(databaseReader["Latitude"].ToString());
                    cust.Longitude = Convert.ToDecimal(databaseReader["Longitude"].ToString());
                    

                }

                return cust;
            }
            catch (Exception e)
            {
                cust = null;
                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                GC.Collect();
            }
            return cust;
        }
        public void AddCustomer(Customer cust)
        {
            SqlConnection databaseConnection = null;           
    

            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_AddCustomer", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@Name", cust.Name));
                commandBuilder.Parameters.Add(new SqlParameter("@Latitude", cust.Latitude));
                commandBuilder.Parameters.Add(new SqlParameter("@Longitude", cust.Longitude));

                commandBuilder.ExecuteNonQuery();

               
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                GC.Collect();
               
            }
           
        }
        public void UpdateCustomer(Customer cust)
        {
            SqlConnection databaseConnection = null;


            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_UpdateCustomer", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@ID", cust.ID));
                commandBuilder.Parameters.Add(new SqlParameter("@Name", cust.Name));
                commandBuilder.Parameters.Add(new SqlParameter("@Latitude", cust.Latitude));
                commandBuilder.Parameters.Add(new SqlParameter("@Longitude", cust.Longitude));

                commandBuilder.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                GC.Collect();

            }

        }
        public void DeleteCustomer(int ID)
        {
            SqlConnection databaseConnection = null;


            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_DeleteCustomer", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@ID", ID));


                commandBuilder.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                GC.Collect();

            }

        }



        public List<CustomerContacts> SelectAllCustomerContacts(int customerID)
        {
            SqlConnection databaseConnection = null;
            SqlDataReader databaseReader = null;
            CustomerContacts custContacts = null;
            List<CustomerContacts> listOfCustContacts = null;

            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_SelectAllCustomerContacts", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@CustomerID", customerID));

                databaseReader = commandBuilder.ExecuteReader();

                listOfCustContacts = new List<CustomerContacts>();
                while (databaseReader.Read())
                {
                    custContacts = new CustomerContacts();
                    custContacts.ID = int.Parse(databaseReader["ID"].ToString());
                    custContacts.Name = databaseReader["Name"].ToString();
                    custContacts.Email = databaseReader["Email"].ToString();
                    custContacts.ContactNumber = databaseReader["ContactNumber"].ToString();
                    custContacts.CustomerID = int.Parse(databaseReader["CustomerID"].ToString());
                    listOfCustContacts.Add(custContacts);
                    
                }

                return listOfCustContacts;
            }
            catch (Exception e)
            {
                listOfCustContacts = null;
                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                GC.Collect();
            }
            return listOfCustContacts;
        }
        public void AddCustomerContacts(CustomerContacts custContacts)
        {
            SqlConnection databaseConnection = null;


            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_AddCustomerContacts", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@Name", custContacts.Name));
                commandBuilder.Parameters.Add(new SqlParameter("@Email", custContacts.Email));
                commandBuilder.Parameters.Add(new SqlParameter("@ContactNumber", custContacts.ContactNumber));
                commandBuilder.Parameters.Add(new SqlParameter("@CustomerID", custContacts.CustomerID));

                commandBuilder.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                GC.Collect();

            }

        }
        public void UpdateCustomerContacts(CustomerContacts custContacts)
        {
            SqlConnection databaseConnection = null;


            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_UpdateCustomerContacts", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@ID", custContacts.ID));
                commandBuilder.Parameters.Add(new SqlParameter("@Name", custContacts.Name));
                commandBuilder.Parameters.Add(new SqlParameter("@Email", custContacts.Email));
                commandBuilder.Parameters.Add(new SqlParameter("@ContactNumber", custContacts.ContactNumber));

                commandBuilder.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                GC.Collect();

            }

        }
        public void DeleteCustomerContacts(CustomerContacts custContacts)
        {
            SqlConnection databaseConnection = null;


            try
            {
                databaseConnection = new SqlConnection("Server=(local);Database=Customer Contact Manager FiveFriday; Integrated Security=SSPI");
                databaseConnection.Open();

                SqlCommand commandBuilder = new SqlCommand("dbo.sp_DeleteCustomerContacts", databaseConnection);
                commandBuilder.CommandType = System.Data.CommandType.StoredProcedure;

                commandBuilder.Parameters.Add(new SqlParameter("@ID", custContacts.ID));


                commandBuilder.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Exception occured in the accessing the data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (databaseConnection != null)
                {
                    databaseConnection.Close();
                }
                GC.Collect();

            }

        }

    }
}
