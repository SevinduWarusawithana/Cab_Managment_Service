using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace Cab_Managment_Service
{
    internal class PlaceOrderClass
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        /*public void addMap(string location, string destination, string date)
        {
            string queryInsert = "INSERT INTO Orders (Location, Destination, Order_Date) VALUES (@Location, @Destination, @Date)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(queryInsert, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@Destination", destination);
                        command.Parameters.AddWithValue("@Date", date);
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Order added successfully");
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
        }*/
        
    }
}
