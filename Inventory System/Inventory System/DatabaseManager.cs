using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class DatabaseManager
    {
        private string connectionString = "server=localhost;username=root;password=;database=inventorysystem";

        public string[] GetUserInfo(string username)
        {
            string[] userInfo = new string[3]; // Assuming two elements for first name and last name

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT UserId, firstname, lastname FROM users WHERE username = @username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userInfo[0] = reader["UserId"].ToString();
                            userInfo[1] = reader["firstname"].ToString();
                            userInfo[2] = reader["lastname"].ToString();
                        }
                    }
                }
            }

            return userInfo;
        }
    }
}
