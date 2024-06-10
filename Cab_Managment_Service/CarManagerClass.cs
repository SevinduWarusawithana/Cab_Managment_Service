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
    internal class CarManagerClass
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        
        //add car method
        public static int addCar(Vehicle vehicle)
        {


            string queryInsert = "INSERT INTO Car (Car_Name, Plate_Number, Available_Car) OUTPUT INSERTED.Car_ID VALUES (@Name, @NUMBER, @Availability)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryInsert, connection))
                    {
                        // add parameters
                        command.Parameters.AddWithValue("@Name", vehicle.Vehicle_Name);
                        command.Parameters.AddWithValue("@NUMBER", vehicle.Vehicle_Plate);
                        command.Parameters.AddWithValue("@Availability", vehicle.Vehicle_Availability);
                        connection.Open();

                        // Execute the command and retrieve the newly created ID to instantiate an object
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

        //remove car method
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
                            MessageBox.Show("Successfully removed car");
                        }
                        else
                        {
                            MessageBox.Show("No car found with the given ID");
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


        //get car table to the data grid
        public static DataTable GetAllCars()
        {
            DataTable carsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Car";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(carsTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return carsTable;
        }


        //select a car by ID
        public static DataTable getCarDataById(int id)
        {
            DataTable dataTable = new DataTable();

            // sql query to select a record from the database using the ID
            string query = "SELECT * FROM Car WHERE Car_Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // add the ID parameter to the sql command
                        command.Parameters.AddWithValue("@Id", id);

                        // create a new SqlDataAdapter
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // populate the DataTable with data from the database
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
