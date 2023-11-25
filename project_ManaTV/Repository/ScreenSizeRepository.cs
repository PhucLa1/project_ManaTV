using project_ManaTV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Repository
{
    public class ScreenSizeRepository
    {
        Database db = new Database();

        public List<ScreenSize> GetAll()
        {
            var lstScreenSize = new List<ScreenSize>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from ScreenSize";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ScreenSize = new ScreenSize();
                        ScreenSize.Id = (int)reader["id"];
                        ScreenSize.Screen_size = (float)(double)reader["screen_size"];
                        lstScreenSize.Add(ScreenSize);
                    }
                }
            }
            return lstScreenSize;
        }

        public ScreenSize GetById(int id)
        {
            var ScreenSize = new ScreenSize();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from ScreenSize where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ScreenSize.Id = (int)reader["id"];
                        ScreenSize.Screen_size = (float)(double)reader["screen_size"];;
                    }
                }
            }
            return ScreenSize;
        }

        public void AddNew(ScreenSize ScreenSize)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert ScreenSize(screen_size) " +
                                        "values (@screen_size)";
                command.Parameters.Add("@screen_size", SqlDbType.Float).Value = ScreenSize.Screen_size;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE ScreenSize where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(ScreenSize customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update ScreenSize 
                                        set screen_size=@screen_size
                                        where id=@id";
                command.Parameters.Add("@screen_size", SqlDbType.Float).Value = customer.Screen_size;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
