using System;
using System.Data.SqlClient;

namespace VideoGameClub.Data
{
    public class DatabaseHelper
    {
        // Connection string (Ensure Server name matches your local SQL Server instance)
        private readonly string _connectionString = "Server=Kurium;Database=VideoGameClubDB;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                // Kept in Spanish for user visibility
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}