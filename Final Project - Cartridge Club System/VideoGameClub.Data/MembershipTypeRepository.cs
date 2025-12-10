using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VideoGameClub.Entities;

namespace VideoGameClub.Data
{
    public class MembershipTypeRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public List<MembershipType> GetAll()
        {
            var list = new List<MembershipType>();
            using (var connection = _dbHelper.GetConnection())
            {
                string query = "SELECT MembershipTypeId, Name, Cost FROM MembershipType";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new MembershipType
                            {
                                MembershipTypeId = Convert.ToInt32(reader["MembershipTypeId"]),
                                Name = reader["Name"].ToString(),
                                Cost = Convert.ToDecimal(reader["Cost"])
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}