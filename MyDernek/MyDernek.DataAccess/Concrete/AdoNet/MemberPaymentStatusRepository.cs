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
    public class MemberPaymentStatusRepository : IEntityRepository<MemberPaymentStatus>
    {
        private readonly string _connectionString;
        
        public MemberPaymentStatusRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public void Add(MemberPaymentStatus entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO MemberPaymentStatus(TcKimlik, PaymentDate, AmountPaid) " +
                    "VALUES (@TcKimlik, @PaymentDate, @AmountPaid)";
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = insertQuery;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@TcKimlik", entity.TcKimlik);
                    command.Parameters.AddWithValue("@PaymentDate", entity.PaymentDate.ToString());
                    command.Parameters.AddWithValue("@AmountPaid", entity.AmountPaid);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(MemberPaymentStatus entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM MemberPaymentStatus WHERE MemberPaymentStatusId=@MemberPaymentStatusId";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@MemberPaymentStatusId", entity.MemberPaymentStatusId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(MemberPaymentStatus entity)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE MemberPaymentStatus SET " +
                                                        "TcKimlik=@TcKimlik, " +
                                                        "FirstName=@FirstName," +
                                                        "LastName=@LastName, " +
                                                        "Email=@Email, " +
                                                        "AmountPaid=@AmountPaid, " +
                                                        "PaymentDate=@PaymentDate, " +
                                    " WHERE MemberPaymentStatusId=@MemberPaymentStatusId";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MemberPaymentStatusId", entity.MemberPaymentStatusId);
                    command.Parameters.AddWithValue("@TcKimlik", entity.TcKimlik);
                    command.Parameters.AddWithValue("@PaymentDate", entity.PaymentDate);
                    command.Parameters.AddWithValue("@AmountPaid", entity.AmountPaid);
                    command.Parameters.AddWithValue("@FirstName", entity.Member.FirstName);
                    command.Parameters.AddWithValue("@LastName", entity.Member.LastName);
                    command.Parameters.AddWithValue("@Email", entity.Member.Email);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public MemberPaymentStatus Get(string TcKimlik)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT MemberPaymentStatus.*, Member.FirstName, Member.LasName, Member.Emial FROM MemberPaymentStatus inner join Member on MemberPaymentStatus.TcKimlik=Member.TcKimlik WHERE TcKimlik=@TcKimlik";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@TcKimlik", TcKimlik);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MemberPaymentStatus
                            {
                                TcKimlik = reader["TcKimlik"].ToString(),
                                PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                                AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                                Member = new Member
                                {
                                    TcKimlik = reader["TcKimlik"].ToString(),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString()
                                },
                               
                                
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

        public List<MemberPaymentStatus> GetAll(string filter = null)
        {
            List<MemberPaymentStatus> memberPaymentStatuses = new List<MemberPaymentStatus>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT MemberPaymentStatus.*, Member.FirstName, Member.LastName, Member.Email FROM MemberPaymentStatus inner join Member on MemberPaymentStatus.TcKimlik= Member.TcKimlik";
                    
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MemberPaymentStatus memberPaymentStatus = new MemberPaymentStatus
                            {
                                TcKimlik = reader["TcKimlik"].ToString(),
                                AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                                PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                                Member = new Member
                                {
                                    TcKimlik = reader["TcKimlik"].ToString(),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString()
                                }
                                
                            };

                            memberPaymentStatuses.Add(memberPaymentStatus);
                        }
                    }
                }
            }

            return memberPaymentStatuses;
        }

    }
}
