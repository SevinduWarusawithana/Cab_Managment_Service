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
    internal class CustomerManager
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        //add customer method
        public static int addCustomer(Customer customer)
        {
            string queryInsert = "INSERT INTO Customers (Customer_Name, Contact_Customer, Customer_Username, Customer_Password) OUTPUT INSERTED.Customer_ID VALUES (@Name, @Contact, @Username, @Password)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Contact", customer.UserContact);
                    command.Parameters.AddWithValue("@Username", customer.UserName);
                    command.Parameters.AddWithValue("@Password", customer.Password);


                    try
                    {
                        connection.Open();
                        int newID = Convert.ToInt32(command.ExecuteScalar());
                        return newID;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error happend! " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        //getting available car table and available driver table to the datagrids
        public static void ShowAvailableData(DataGridView dataGridView, string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        //customer place an order
        public static int placeorder(Order order)
        {
            try
            {
                int orderId;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check car availability and select them
                    string checkCarQuery = "SELECT Available_Car FROM Car WHERE Car_ID = @CarId";
                    SqlCommand carCommand = new SqlCommand(checkCarQuery, connection);
                    carCommand.Parameters.AddWithValue("@CarId", order.CarId);
                    bool carAvailable = (bool)carCommand.ExecuteScalar();

                    if (!carAvailable)
                    {
                        MessageBox.Show("Car is Not available");
                        return -1; // car is not available
                    }

                    // Check driver availability and select them
                    string checkDriverQuery = "SELECT Available_Driver FROM Driver WHERE Driver_Id = @DriverId";
                    SqlCommand driverCommand = new SqlCommand(checkDriverQuery, connection);
                    driverCommand.Parameters.AddWithValue("@DriverId", order.DriverId);
                    bool driverAvailable = (bool)driverCommand.ExecuteScalar();

                    if (!driverAvailable)
                    {
                        MessageBox.Show("Driver is not available");
                        return -1; // Driver is not available
                    }

                    // Insert order details
                    string insertOrderQuery = @"INSERT INTO Orders (Customer_ID, Car_ID, Driver_ID, Order_Date, Location, Destination) OUTPUT INSERTED.Order_ID VALUES (@CustomerId, @CarId, @DriverId, @OrderDate, @Location, @Destination)";
                    SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
                    insertOrderCommand.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    insertOrderCommand.Parameters.AddWithValue("@CarId", order.CarId);
                    insertOrderCommand.Parameters.AddWithValue("@DriverId", order.DriverId);
                    insertOrderCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    insertOrderCommand.Parameters.AddWithValue("@Location", order.Location);
                    insertOrderCommand.Parameters.AddWithValue("@Destination", order.Destination);

                    orderId = Convert.ToInt32(insertOrderCommand.ExecuteScalar());

                    // Update car availability in table
                    string updateCarQuery = "UPDATE Car SET Available_Car = 0 WHERE Car_ID = @CarId";
                    SqlCommand updateCarCommand = new SqlCommand(updateCarQuery, connection);
                    updateCarCommand.Parameters.AddWithValue("@CarId", order.CarId);
                    updateCarCommand.ExecuteNonQuery();

                    // Update driver availability in table
                    string updateDriverQuery = "UPDATE Driver SET Available_Driver = 0 WHERE Driver_Id = @DriverId";
                    SqlCommand updateDriverCommand = new SqlCommand(updateDriverQuery, connection);
                    updateDriverCommand.Parameters.AddWithValue("@DriverId", order.DriverId);
                    updateDriverCommand.ExecuteNonQuery();
                }

                return orderId;
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

        //fetch that data to the customer table
        public static int FetchId(string username, string password)
        {
            int customerId;
            string query = "SELECT Customer_ID FROM Customers WHERE Customer_Username = @Username AND Customer_Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        customerId = Convert.ToInt32(result);
                        return customerId;

                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., log the error)
                        Console.WriteLine("Error happend! " + ex.Message);
                        return -1;
                    }
                }
            }
        }
        
        //show the orders in admin dashboard (method over loading)
        public static void LoadCustomerOrders(DataGridView dataGridView)
        {
            string query = "SELECT * FROM Orders";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happend! " + ex.Message);
            }
        }

        //show the orders in customer view my orders (method over loading)
        public static void LoadCustomerOrders(DataGridView dataGridView, string username, string password)
        {
            int user_Id = FetchId(username, password);
            string query = $"SELECT * FROM Orders WHERE Customer_ID = {user_Id}";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happend! " + ex.Message);
            }

        }

    }
}
