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
    public class DuesRepository : IEntityRepository<Dues>
    {
        private readonly string _connectionString;
        public DuesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(Dues entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Dues(DuesYear, DuesMonth, DuesAmount) " +
                    "VALUES (@DuesYear, @DuesMonth, @DuesAmount)";
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = insertQuery;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@DuesYear", entity.DuesYear);
                    command.Parameters.AddWithValue("@DuesMonth", entity.DuesMonth);
                    command.Parameters.AddWithValue("@DuesAmount", entity.DuesAmount);
                   
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Dues entity)
        {
            using(OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Dues WHERE DuesId=@DuesId";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@DuesId", entity.DuesId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public Dues Get(int month, int year)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Dues Where DuesYear=@year AND DuesMonth=@month";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@year", year.ToString());
                    command.Parameters.AddWithValue("@month", month.ToString());
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Dues
                            {
                                DuesId = Convert.ToInt32(reader["DuesId"]),
                                DuesYear = Convert.ToInt32(reader["DuesYear"]),
                                DuesMonth = Convert.ToInt32(reader["DuesMonth"]),
                                DuesAmount = Convert.ToInt32(reader["DuesAmount"])
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

        public Dues Get(string id)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Dues Where DuesId=@id";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Dues
                            {
                                DuesId = Convert.ToInt32(reader["DuesId"]),
                                DuesYear = Convert.ToInt32(reader["DuesYear"]),
                                DuesMonth = Convert.ToInt32(reader["DuesMonth"]),
                                DuesAmount = Convert.ToInt32(reader["DuesAmount"])
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

        public List<Dues> GetAll(string filter = null)
        {
            List<Dues> dueses = new List<Dues>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Dues";

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dues due = new Dues
                            {
                                DuesId = Convert.ToInt32(reader["DuesId"]),
                                DuesYear = Convert.ToInt32(reader["DuesYear"]),
                                DuesMonth = Convert.ToInt32(reader["DuesMonth"]),
                                DuesAmount = Convert.ToInt32(reader["DuesAmount"])
                            };

                            dueses.Add(due);
                        }
                    }
                }
            }

            return dueses;
        }

        public void Update(Dues entity)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Dues SET " +
                                                            "DuesYear=@DuesYear," +
                                                            "DuesMonth=@DuesMonth, " +
                                                            "DuesAmount=@DuesAmount " +
                                        " WHERE DuesId=@DuesId";
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DuesYear", entity.DuesYear);
                        command.Parameters.AddWithValue("@DuesMonth", entity.DuesMonth);
                        command.Parameters.AddWithValue("@DuesAmount", entity.DuesAmount);
                        command.Parameters.AddWithValue("@DuesId", entity.DuesId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

