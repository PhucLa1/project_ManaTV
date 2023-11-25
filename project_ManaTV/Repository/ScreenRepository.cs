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
    public class ScreenRepository
    {
        Database db = new Database();

        public List<Screen> GetAll()
        {
            var lstScreen = new List<Screen>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Screen";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Screen = new Screen();
                        Screen.Id = (int)reader["id"];
                        Screen.Name = reader["screen_name"].ToString();
                        lstScreen.Add(Screen);
                    }
                }
            }
            return lstScreen;
        }

        public Screen GetById(int id)
        {
            var Screen = new Screen();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from Screen where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Screen.Id = (int)reader["id"];
                        Screen.Name = reader["screen_name"].ToString();
                    }
                }
            }
            return Screen;
        }

        public void AddNew(Screen Screen)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Screen(screen_name) " +
                                        "values (@screen_name)";
                command.Parameters.Add("@screen_name", SqlDbType.NVarChar).Value = Screen.Name;
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
                command.CommandText = "DELETE Screen where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Screen customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Screen 
                                        set screen_name=@screen_name
                                        where id=@id";
                command.Parameters.Add("@screen_name", SqlDbType.NVarChar).Value = customer.Name;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
