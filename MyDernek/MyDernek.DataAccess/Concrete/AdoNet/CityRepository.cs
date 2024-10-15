using MyDernek.DataAccess.Abstract;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.DataAccess.Concrete.AdoNet
{
    public class CityRepository : IEntityRepository<City>
    {
        private readonly string _connectionString;
        public CityRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(City entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO City(CityId, CityName) " +
                    "VALUES (@CityId, @CityName)";
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = insertQuery;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@CityId", entity.CityId);
                    command.Parameters.AddWithValue("@FirstName", entity.CityName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(City entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM City WHERE CityId=@CityId";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@CityId", entity.CityId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public City Get(string id)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM City WHERE CityId=@CityId";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@CityId", id);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new City
                            {
                                CityId = reader["CityId"].ToString(),
                                CityName = reader["CityName"].ToString()
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

        public List<City> GetAll(string filter = null)
        {
            List<City> cities= new List<City>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM City";

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            City city = new City
                            {
                                CityId = reader["CityId"].ToString(),   
                                CityName = reader["CityName"].ToString()
                            };

                            cities.Add(city);
                        }
                    }
                }
            }

            return cities;
        }

        public void Update(City entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE City SET " +
                                                        "CityId=@CityId, " +
                                                        "CityName=@CityName" +
                                    " WHERE CityId=@CityId";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@CityId", entity.CityId);
                    command.Parameters.AddWithValue("@CityName", entity.CityName);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
