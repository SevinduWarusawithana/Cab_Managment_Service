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

        // Authenticate user method
        public static bool authenticateUser(string username, string password, string userRole)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Query to retrieve the password for the given username
                    string query = $"SELECT {userRole}_Password FROM {userRole}s WHERE {userRole}_Username = @username";

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    // Run the query to obtain the password
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Username exists, verify if the entered password matches
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
                    MessageBox.Show($"Error happend! : {ex.Message}");
                    return false;
                }
            }
        }
    }
}
