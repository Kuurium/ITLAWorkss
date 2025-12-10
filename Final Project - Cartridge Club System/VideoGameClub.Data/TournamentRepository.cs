using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VideoGameClub.Entities;

namespace VideoGameClub.Data
{
    public class TournamentRepository
    {
        private readonly DatabaseHelper _dbHelper;

        public TournamentRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        public void Add(Tournament tournament)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = @"INSERT INTO Tournament (GameId, TournamentName, StartDate, MaxCapacity, TournamentFormat, Prizes) 
                                VALUES 
                                (@GameId, @TournamentName, @StartDate, @MaxCapacity, @TournamentFormat, @Prizes)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GameId", tournament.GameId);
                    command.Parameters.AddWithValue("@TournamentName", tournament.TournamentName);
                    command.Parameters.AddWithValue("@StartDate", tournament.StartDate);
                    command.Parameters.AddWithValue("@MaxCapacity", tournament.MaxCapacity);
                    command.Parameters.AddWithValue("@TournamentFormat", tournament.TournamentFormat);
                    command.Parameters.AddWithValue("@Prizes", tournament.Prizes);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Tournament> GetAll()
        {
            var list = new List<Tournament>();

            using (var connection = _dbHelper.GetConnection())
            {
                // JOIN: Get Game Title along with Tournament details
                string query = @"SELECT T.*, G.Title as GameTitle 
                                FROM Tournament T
                                INNER JOIN Game G ON T.GameId = G.GameId";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var t = new Tournament
                            {
                                TournamentId = Convert.ToInt32(reader["TournamentId"]),
                                TournamentName = reader["TournamentName"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                MaxCapacity = Convert.ToInt32(reader["MaxCapacity"]),
                                TournamentFormat = reader["TournamentFormat"].ToString(),
                                Prizes = reader["Prizes"].ToString(),
                                Status = Convert.ToInt32(reader["Status"]),
                                GameId = Convert.ToInt32(reader["GameId"]),

                                // Populate the Game object
                                Game = new Game
                                {
                                    GameId = Convert.ToInt32(reader["GameId"]),
                                    Title = reader["GameTitle"].ToString()
                                }
                            };

                            list.Add(t);
                        }
                    }
                }
            }
            return list;
        }

        public int GetCapacity(int tournamentId)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "SELECT MaxCapacity FROM Tournament WHERE TournamentId = @TournamentId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentId", tournamentId);

                    // Convert result to int. Default to 0 if null.
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public void UpdateStatus(int tournamentId, int newStatus)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "UPDATE Tournament SET Status = @Status WHERE TournamentId = @Id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@Id", tournamentId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "DELETE FROM Tournament WHERE TournamentId = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}