using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    internal class AddressRepo
    {
        public static string connectionstring = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=AddressBookService;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionstring);
        public bool AddAddress(AddressModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddAddress", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@ZIP", model.ZIP);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", model.Email);
                    command.Parameters.AddWithValue("@City", model.City);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
            finally
            {
                this.connection.Close();
            }
        }

        public void GetAllAddress()
        {
            try
            {
                AddressModel addressModel = new AddressModel();
                using (this.connection)
                {
                    string query = @"Select FirstName,LastName,PhoneNumber,Address,State,City,ZIP,Email from Address;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            addressModel.FirstName = dr.GetString(0);
                            addressModel.LastName = dr.GetString(1);
                            addressModel.PhoneNumber = dr.GetString(2);
                            addressModel.Address = dr.GetString(3);
                            addressModel.State = dr.GetString(4);
                            addressModel.City = dr.GetString(5);
                            addressModel.ZIP = dr.GetString(6);
                            addressModel.Email = dr.GetString(7);


                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", addressModel.FirstName,addressModel.LastName,addressModel.PhoneNumber,addressModel.Address,addressModel.State,addressModel.City,addressModel.ZIP,addressModel.Email);

                        }
                    }
                    else
                    {
                        Console.WriteLine("no data found");
                    }
                    dr.Close();
                    this.connection.Close();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}

            
    



    
            
            
            




                    
                
            
        
    










                
            
     
    

