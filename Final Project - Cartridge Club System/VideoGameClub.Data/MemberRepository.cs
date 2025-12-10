using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VideoGameClub.Entities;

namespace VideoGameClub.Data
{
    public class MemberRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public void Add(Member member)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = @"INSERT INTO Member 
                                (FirstName, LastName, BirthDate, Email, Phone, Address, MembershipTypeId, Status, JoinDate) 
                                VALUES 
                                (@FirstName, @LastName, @BirthDate, @Email, @Phone, @Address, @MembershipTypeId, @Status, @JoinDate)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@BirthDate", member.BirthDate);
                    command.Parameters.AddWithValue("@Email", member.Email);
                    command.Parameters.AddWithValue("@Phone", member.Phone);
                    command.Parameters.AddWithValue("@Address", (object)member.Address ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MembershipTypeId", member.MembershipTypeId);
                    command.Parameters.AddWithValue("@Status", member.Status);
                    command.Parameters.AddWithValue("@JoinDate", member.JoinDate);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Member GetById(int id)
        {
            Member member = null;

            using (var connection = _dbHelper.GetConnection())
            {
                string query = "SELECT * FROM Member WHERE MemberId = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = MapReaderToMember(reader);
                        }
                    }
                }
            }
            return member;
        }

        public Member GetByEmail(string email)
        {
            Member member = null;

            using (var connection = _dbHelper.GetConnection())
            {
                string query = "SELECT * FROM Member WHERE Email = @Email";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = MapReaderToMember(reader);
                        }
                    }
                }
            }
            return member;
        }

        public void Update(Member member)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = @"UPDATE Member 
                                SET FirstName = @FirstName,
                                    LastName = @LastName,
                                    Email = @Email,
                                    Phone = @Phone,
                                    Address = @Address,
                                    BirthDate = @BirthDate,
                                    MembershipTypeId = @MembershipTypeId,
                                    Status = @Status,
                                    SkillLevel = @SkillLevel,
                                    ClubRole = @ClubRole
                                WHERE MemberId = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@Email", member.Email);
                    command.Parameters.AddWithValue("@Phone", member.Phone);
                    command.Parameters.AddWithValue("@Address", (object)member.Address ?? DBNull.Value);
                    command.Parameters.AddWithValue("@BirthDate", member.BirthDate);
                    command.Parameters.AddWithValue("@MembershipTypeId", member.MembershipTypeId);
                    command.Parameters.AddWithValue("@Status", member.Status);
                    command.Parameters.AddWithValue("@Id", member.Id);
                    command.Parameters.AddWithValue("@SkillLevel", (object)member.SkillLevel ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ClubRole", (object)member.ClubRole ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Member> GetAll()
        {
            var list = new List<Member>();

            using (var connection = _dbHelper.GetConnection())
            {
                // Join with MembershipType to get Name (Rango) and Cost (Costo)
                string query = @"SELECT m.*, mt.Name as Rango, mt.Cost as Costo 
                                FROM Member m 
                                INNER JOIN MembershipType mt ON m.MembershipTypeId = mt.MembershipTypeId";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var member = MapReaderToMember(reader);

                            // Additional mapping for the joined columns
                            member.MembershipType = new MembershipType
                            {
                                Name = reader["Rango"].ToString(),
                                Cost = Convert.ToDecimal(reader["Costo"])
                            };

                            list.Add(member);
                        }
                    }
                }
            }
            return list;
        }

        public void Delete(int id)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "DELETE FROM Member WHERE MemberId = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Helper method to map common fields to avoid code duplication
        private Member MapReaderToMember(SqlDataReader reader)
        {
            return new Member
            {
                Id = Convert.ToInt32(reader["MemberId"]),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString(),
                Phone = reader["Phone"].ToString(),
                Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString(),
                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                JoinDate = Convert.ToDateTime(reader["JoinDate"]),
                MembershipTypeId = Convert.ToInt32(reader["MembershipTypeId"]),
                Status = Convert.ToInt32(reader["Status"]),
                SkillLevel = reader["SkillLevel"] == DBNull.Value ? null : reader["SkillLevel"].ToString(),
                ClubRole = reader["ClubRole"] == DBNull.Value ? null : reader["ClubRole"].ToString(),
                // Check if RenewalDate exists in the result set before reading
                RenewalDate = HasColumn(reader, "RenewalDate") && reader["RenewalDate"] != DBNull.Value
                              ? (DateTime?)Convert.ToDateTime(reader["RenewalDate"]) : null
            };
        }

        private bool HasColumn(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}