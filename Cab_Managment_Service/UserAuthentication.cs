using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_Managment_Service
{
    internal class UserAuthentication
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public static bool authenticateUser(string username, string password, string userRole)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Query to fetch the password for the entered username
                    string query = $"SELECT {userRole}_Password FROM {userRole}s WHERE {userRole}_Username = @username";

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    // Execute the query to retrieve the password
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Username found, check if the entered password matches
                        string dbPassword = result.ToString();
                        if (password == dbPassword)
                        {
                            //password matches
                            MessageBox.Show($"Welcome {userRole}");
                            return true;
                        }

                        MessageBox.Show("Incorrect password!");
                        return false;

                    }

                    MessageBox.Show("Username not found!");
                    return false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
