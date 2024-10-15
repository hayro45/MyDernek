using MyDernek.DataAccess.Abstract;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.DataAccess.Concrete.AdoNet
{
    public class MemberRepository : IEntityRepository<Member>
    {
        private readonly string _connectionString;
        public MemberRepository(string connectionString)
        { 
            _connectionString = connectionString;
        }
        public void Add(Member entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Member(TcKimlik, FirstName, LastName, Email, UserPassword, BloodTypeId, CityId, IsActive, IsAdmin, DuesAmount, DueDate, DebtAmount) " +
                    "VALUES (@TcKimlik, @FirstName, @LastName, @Email, @UserPassword, @BloodTypeId, @CityId, @IsActive, @IsAdmin, @DuesAmount,@DueDate, @DebtAmount)";
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = insertQuery;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@TcKimlik", entity.TcKimlik);
                    command.Parameters.AddWithValue("@FirstName", entity.FirstName);
                    command.Parameters.AddWithValue("@LastName", entity.LastName);
                    command.Parameters.AddWithValue("@Email", entity.Email);
                    command.Parameters.AddWithValue("@UserPassword", entity.UserPassword);
                    command.Parameters.AddWithValue("@BloodTypeId", entity.BloodTypeId);
                    command.Parameters.AddWithValue("@CityId", entity.CityId);
                    command.Parameters.AddWithValue("@IsActive", entity.IsActive);
                    command.Parameters.AddWithValue("@IsAdmin", entity.IsAdmin);
                    command.Parameters.AddWithValue("@DuesAmount", entity.DuesAmount);
                    command.Parameters.AddWithValue("@DueDate", entity.DueDate.ToString());
                    command.Parameters.AddWithValue("@DebtAmount", entity.DebtAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Member Get(string TcKimlik)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Member.*, City.CityName, BloodType.TypeName FROM(Member inner join BloodType on Member.BloodtypeId=BloodType.BloodTypeId ) inner join City on Member.CityId=City.CityId WHERE TcKimlik=@TcKimlik";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@TcKimlik", TcKimlik);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            return new Member
                            {
                                TcKimlik = reader["TcKimlik"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                UserPassword = reader["UserPassword"].ToString(),
                                Email = reader["Email"].ToString(),
                                BloodTypeId = reader["BloodTypeId"].ToString(), 
                                CityId = reader["CityId"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                IsAdmin = Convert.ToBoolean(reader["IsAdmin"]),
                                DuesAmount = Convert.ToDecimal(reader["DuesAmount"]),
                                DueDate = Convert.ToDateTime(reader["DueDate"]),
                                DebtAmount = Convert.ToDecimal(reader["DebtAmount"]),
                                City = new City
                                {
                                    CityId = reader["CityId"].ToString(),
                                    CityName = reader["CityName"].ToString()
                                },  
                                BloodType = new BloodType
                                {
                                    BloodTypeId = reader["BloodTypeId"].ToString(),
                                    TypeName = reader["TypeName"].ToString()
                                }   
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
        public DataTable GetAllWithNames()
        {
            OleDbConnection connection = new OleDbConnection(_connectionString);
            connection.Open();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Member.TcKimlik, Member.FirstName, Member.LastName, Member.Email, Member.UserPassword, Member.IsActive, Member.IsAdmin, Member.DueDate, Member.DuesAmount, Member.DebtAmount, City.CityName, BloodType.TypeName FROM(Member inner join BloodType on Member.BloodtypeId=BloodType.BloodTypeId ) inner join City on Member.CityId=City.CityId", connection);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            return tablo;
        }
        public List<Member> GetAll()
        {
            List<Member> members = new List<Member>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Member.*, City.CityName, BloodType.TypeName FROM(Member inner join BloodType on Member.BloodtypeId=BloodType.BloodTypeId ) inner join City on Member.CityId=City.CityId";

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                TcKimlik = reader["TcKimlik"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                UserPassword = reader["UserPassword"].ToString(),
                                Email = reader["Email"].ToString(),
                                BloodTypeId = reader["BloodTypeId"].ToString(),
                                CityId = reader["CityId"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                IsAdmin = Convert.ToBoolean(reader["IsAdmin"]),
                                DuesAmount = Convert.ToDecimal(reader["DuesAmount"]),
                                DueDate = Convert.ToDateTime(reader["DueDate"]),
                                DebtAmount = Convert.ToDecimal(reader["DebtAmount"]),
                                City = new City
                                {
                                    CityId = reader["CityId"].ToString(),
                                    CityName = reader["CityName"].ToString()
                                },  
                                BloodType = new BloodType 
                                {
                                    BloodTypeId = reader["BloodTypeId"].ToString(),
                                    TypeName = reader["TypeName"].ToString()
                                }
                            };

                            members.Add(member);
                        }
                    }
                }
            }

            return members;
        }

        public void Update(Member entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Member SET " +
                                                        "TcKimlik=@TcKimlik, " +
                                                        "FirstName=@FirstName," +
                                                        "LastName=@LastName, " +
                                                        "Email=@Email, " +
                                                        "UserPassword=@UserPassword, " +
                                                        "BloodTypeId=@BloodTypeId, " +
                                                        "CityId=@CityId, " +
                                                        "IsActive=@IsActive, " +
                                                        "IsAdmin=@IsAdmin, " +
                                                        "DuesAmount=@DuesAmount, " +
                                                        "DueDate=@DueDate," +
                                                        "DebtAmount=@DebtAmount" +
                                    " WHERE TcKimlik=@TcKimlik";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TcKimlik", entity.TcKimlik);
                    command.Parameters.AddWithValue("@FirstName", entity.FirstName);
                    command.Parameters.AddWithValue("@LastName", entity.LastName);
                    command.Parameters.AddWithValue("@Email", entity.Email);
                    command.Parameters.AddWithValue("@UserPassword", entity.UserPassword);
                    command.Parameters.AddWithValue("@BloodTypeId", entity.BloodTypeId);
                    command.Parameters.AddWithValue("@CityId", entity.CityId);
                    command.Parameters.AddWithValue("@IsActive", entity.IsActive);
                    command.Parameters.AddWithValue("@IsAdmin", entity.IsAdmin);
                    command.Parameters.AddWithValue("@DuesAmount", entity.DuesAmount);
                    command.Parameters.AddWithValue("@DueDate", entity.DueDate);
                    command.Parameters.AddWithValue("@DebtAmount", entity.DebtAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Member entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Member WHERE TcKimlik=@TcKimlik";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@TcKimlik", entity.TcKimlik);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Member> GetAll(string filter = null)
        {
            throw new NotImplementedException();
        }

        

    }
}
