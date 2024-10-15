using MyDernek.DataAccess.Abstract;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.DataAccess.Concrete.AdoNet
{
    public class BloodTypeRepository : IEntityRepository<BloodType>
    {
        private readonly string _connectionString;
        public BloodTypeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(BloodType entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO BloodType(BloodTypeId, TypeName) " +
                    "VALUES (@BloodTypeId, @TypeName)";
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = insertQuery;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@BloodTypeId", entity.BloodTypeId);
                    command.Parameters.AddWithValue("@TypeName", entity.TypeName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(BloodType entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM BloodType WHERE BloodTypeId=@BloodTypeId";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@BloodTypeId", entity.BloodTypeId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public BloodType Get(string id)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM BloodType WHERE BloodTypeId=@BloodTypeId";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@TcKimlik", id);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new BloodType
                            {
                                BloodTypeId = reader["BloodTypeId"].ToString(),
                                TypeName = reader["TypeName"].ToString(),
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public List<BloodType> GetAll(string filter = null)
        {
            List<BloodType> bloodTypes = new List<BloodType>();
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM BloodType";

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BloodType bloodType = new BloodType
                            {
                                BloodTypeId = reader["BloodTypeId"].ToString(),
                                TypeName = reader["TypeName"].ToString()
                            };
                           
                            bloodTypes.Add(bloodType);
                        }
                    }
                }
            }

            return bloodTypes;

        }

        public void Update(BloodType entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE BloodType SET " +
                                                        "TypeName=@TypeName" +
                                    " WHERE BloodTypeId=@BloodTypeId";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@BloodTypeId", entity.BloodTypeId);
                    command.Parameters.AddWithValue("@TypeName", entity.TypeName);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
