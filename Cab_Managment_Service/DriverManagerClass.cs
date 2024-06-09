using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_Managment_Service
{
    internal class DriverManagerClass
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public static int addDriver(Driver driver)
        {
            string queryInsert = @"INSERT INTO Driver (Driver_Name, Driver_Contact, Available_Driver) OUTPUT INSERTED.Driver_Id VALUES (@Name, @Contact, @Availability);";

            try
            {
                using (SqlConnection connection = new SqlConnection (connectionString))
                {
                    using (SqlCommand command = new SqlCommand (queryInsert, connection))
                    {
                        // Adding parameters
                        command.Parameters.AddWithValue("@Name", driver.UserName);
                        command.Parameters.AddWithValue("@Contact", driver.UserContact);
                        command.Parameters.AddWithValue("@Availability", driver.Availability);
                        connection.Open();

                        // Execute the command and fetch the newly created ID to create an Object
                        int newID = Convert.ToInt32(command.ExecuteScalar());
                        return newID;


                    }
                }
            }

            /*string queryInsert = "INSERT INTO Driver (Driver_Name, Driver_Contact, Available_Driver) VALUES (@Name, @Contact, @Availability)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryInsert, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Availability", availability);
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Driver added successfully");
                    }

                }
            }*/
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
        }

        public static void removeDriver(int id)
        {
            string queryDelete = "DELETE FROM Driver WHERE Driver_ID = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryDelete, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Driver removed successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Driver found with the specified ID");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static DataTable GetAllDrivers()
        {
            DataTable driversTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Driver";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(driversTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return driversTable;
        }

        

        public static DataTable getDriverDataById(int id)
        {
            DataTable dataTable = new DataTable();

            // SQL query to select the record from the database based on the ID
            string query = "SELECT * FROM Driver WHERE Driver_Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for the ID
                        command.Parameters.AddWithValue("@Id", id);

                        // Create a new SqlDataAdapter
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dataTable;
        }
    }
}
