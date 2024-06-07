using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_Managment_Service
{
    internal class CarManagerClass
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public static int addCar(Vehicle vehicle)
        {


            string queryInsert = "INSERT INTO Car (Car_Name, Plate_Number, Available_Car) OUTPUT INSERTED.Car_ID VALUES (@Name, @NUMBER, @Availability)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryInsert, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Name", vehicle.Vehicle_Name);
                        command.Parameters.AddWithValue("@NUMBER", vehicle.Vehicle_Plate);
                        command.Parameters.AddWithValue("@Availability", vehicle.Vehicle_Availability);
                        connection.Open();

                        // Execute the command and fetch the newly created ID to create an Object
                        int newID = Convert.ToInt32(command.ExecuteScalar());
                        return newID;

                    }

                }
            }
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

        public static void removeCar(int id)
        {
            string queryDelete = "DELETE FROM Car WHERE Car_ID = @Id";

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
                            MessageBox.Show("Car removed successfully");
                        }
                        else
                        {
                            MessageBox.Show("No car found with the specified ID");
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
