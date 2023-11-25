using project_ManaTV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Repository
{
    public class ColorRepository
    {
        Database db = new Database();

        public List<Colors> GetAll()
        {
            var lstColors = new List<Colors>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Colors";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var color = new Colors();
                        color.Id = (int)reader["id"];
                        color.R = (int)reader["r"];
                        color.G = (int)reader["g"];
                        color.B = (int)reader["b"];
                        color.color_name = reader["color_name"].ToString();
                        lstColors.Add(color);
                    }
                }
            }
            return lstColors;
        }

        public Colors GetById(int id)
        {
            var color = new Colors();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from  Colors where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        color.Id = (int)reader["id"];
                        color.R = (int)reader["r"];
                        color.G = (int)reader["g"];
                        color.B = (int)reader["b"];
                        color.color_name = reader["color_name"].ToString();
                    }
                }
            }
            return color;
        }

        public void AddNew(Colors color)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Colors (R , G , B , color_name ) " +
                                        "values (@R, @G , @B , @color_name)";
                command.Parameters.Add("@R", SqlDbType.Int).Value = color.R ;
                command.Parameters.Add("@G", SqlDbType.Int).Value = color.G;
                command.Parameters.Add("@B", SqlDbType.Int).Value = color.B;
                command.Parameters.Add("@color_name", SqlDbType.NVarChar).Value = color.color_name;
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
                command.CommandText = "DELETE Colors where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Colors color)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Colors
                                        set R = @R, G= @G , B=@B , color_name = @color_name
                                        where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = color.Id;
                command.Parameters.Add("@R", SqlDbType.Int).Value = color.R;
                command.Parameters.Add("@G", SqlDbType.Int).Value = color.G;
                command.Parameters.Add("@B", SqlDbType.Int).Value = color.B;
                command.Parameters.Add("@color_name", SqlDbType.NVarChar).Value = color.color_name;
                command.ExecuteNonQuery();
            }
        }


    }
}
