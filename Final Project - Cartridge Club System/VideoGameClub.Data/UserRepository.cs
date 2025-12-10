using System;
using System.Data.SqlClient;
using VideoGameClub.Entities;

namespace VideoGameClub.Data
{
    public class UserRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        // 1. Validate Login (Returns true if password is correct)
        public bool ValidateUser(string username, string password)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                // 1. Fetch the stored password for the user
                string query = "SELECT Password FROM Users WHERE Username = @User";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User", username);

                    // ExecuteScalar returns the first cell (the password) or NULL if user not found
                    object result = command.ExecuteScalar();

                    // 2. Check if user exists
                    if (result != null)
                    {
                        string dbPassword = result.ToString();

                        // 3. STRICT COMPARISON IN C#
                        // C# is case-sensitive by default.
                        // If dbPassword is "Hola" and password is "hola", this returns FALSE.
                        if (dbPassword == password)
                        {
                            return true; // Password correct!
                        }
                    }
                }
            }
            // If user doesn't exist or password doesn't match exactly
            return false;
        }

        // 2. Register new Admin
        public void RegisterUser(User user)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "INSERT INTO Users (Username, Password) VALUES (@User, @Pass)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User", user.Username);
                    command.Parameters.AddWithValue("@Pass", user.Password);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}