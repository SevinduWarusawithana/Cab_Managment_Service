using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_Managment_Service
{
    internal class AdminManager
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\APIIT\Sem02 L4\Software Devolopment & Application Modelling 02\cab_system_db\car_management_db.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        
        public static int ChangeAvailability(int id, string availability, string managementType)
        {
            string query = $"UPDATE {managementType} SET Available_{managementType} = @Availability WHERE {managementType}_Id = @Id";

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
            return rowsAffected;
        }

        public static int addAdmin(Admin admin)
        {
            string queryInsert = "INSERT INTO Admins (Admin_Name, Contact_Admin, Admin_Username, Admin_Password) OUTPUT INSERTED.Admin_ID VALUES (@Name, @Contact, @Username, @Password)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    command.Parameters.AddWithValue("@Name", admin.Name);
                    command.Parameters.AddWithValue("@Contact", admin.UserContact);
                    command.Parameters.AddWithValue("@Username", admin.UserName);
                    command.Parameters.AddWithValue("@Password", admin.Password);


                    try
                    {
                        connection.Open();
                        int newID = Convert.ToInt32(command.ExecuteScalar());
                        return newID;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        

    }

}