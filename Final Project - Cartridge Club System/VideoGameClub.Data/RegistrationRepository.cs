using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VideoGameClub.Entities;

namespace VideoGameClub.Data
{
    public class RegistrationRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public void Add(Registration registration)
        {
            using (var connection = _dbHelper.GetConnection())
            {
      
                string query = @"INSERT INTO TournamentRegistration (TournamentId, MemberId, RegistrationDate) 
                                VALUES 
                                (@TournamentId, @MemberId, @RegistrationDate)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentId", registration.TournamentId);
                    command.Parameters.AddWithValue("@MemberId", registration.MemberId);
                    command.Parameters.AddWithValue("@RegistrationDate", registration.RegistrationDate);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<RegistrationDetail> GetAll()
        {
            var list = new List<RegistrationDetail>();

            using (var connection = _dbHelper.GetConnection())
            {
                // Join 4 tables: Registration -> Tournament -> Game -> Member
                string query = @"
                    SELECT 
                        r.RegistrationId, 
                        r.RegistrationDate,
                        t.TournamentName,
                        g.Title as GameTitle,
                        m.FirstName + ' ' + m.LastName as FullName
                    FROM TournamentRegistration r
                    INNER JOIN Tournament t ON r.TournamentId = t.TournamentId
                    INNER JOIN Game g ON t.GameId = g.GameId
                    INNER JOIN Member m ON r.MemberId = m.MemberId";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new RegistrationDetail
                            {
                                RegistrationId = Convert.ToInt32(reader["RegistrationId"]),
                                Date = Convert.ToDateTime(reader["RegistrationDate"]),
                                TournamentName = reader["TournamentName"].ToString(),
                                GameTitle = reader["GameTitle"].ToString(),
                                MemberName = reader["FullName"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public int GetTotalRegistrations(int tournamentId)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                
                string query = "SELECT COUNT(*) FROM TournamentRegistration WHERE TournamentId = @TournamentId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentId", tournamentId);

                    // ExecuteScalar returns a single value (the count)
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void Delete(int registrationId)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "DELETE FROM TournamentRegistration WHERE RegistrationId = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", registrationId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}