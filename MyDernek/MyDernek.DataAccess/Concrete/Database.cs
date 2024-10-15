using MyDernek.Entities.Abstract;
using MyDernek.Entities.Concrete;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyDernek.DataAccess.Concrete
{
    public class Database
    {
        private string _connectionString;
        public Database(string conString)
        {
           _connectionString = conString;
        }
        public string GetDebthMessage()
        {   string message = "";



            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {

                connection.Open();
                string selectQuery = "SELECT * FROM DernekSettings WHERE SettingId=@id";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", 1);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            message =  reader["DernekBorcMesaji"].ToString();
                        }
                        else
                        {
                            return message;
                        }
                    }
                }
            }
            return message;
            
        }

        public void UpdateMessage(string message)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE DernekSettings SET " +
                                     "DernekBorcMesaji=@DernekBorcMesaji " +
                                     "WHERE SettingId=@id";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@DernekBorcMesaji", message);
                    command.Parameters.AddWithValue("@id", 1);
                    command.ExecuteNonQuery();
                    throw new Exception("Mesaj güncellendi");
                }
            }
        }
    
        
    
    }
}
