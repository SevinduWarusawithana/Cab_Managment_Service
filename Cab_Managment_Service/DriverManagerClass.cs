using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_Managment_Service
{
    internal class DriverManagerClass
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public void addDriver(int id, string name, string contact, bool availability)
        {


            string queryInsert = "INSERT INTO Driver (Driver_Name, Driver_Contact, Available_Driver) VALUES (@Name, @Contact, @Availability)";

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

        public void removeDriver(int id)
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
    }
}
