using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ManaTV.Models;
namespace project_ManaTV.Repository
{
    public class ColorRepository
    {
        Database db = new Database();

        public List<Color> GetAll()
        {
            var lstColor = new List<Color>();
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Colors";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var color = new Color();
                        color.Id = (int)reader["id"];
                        color.Name = (string)reader["color_name"];
                        color.Value = (string)reader["color_value"];
                        color.Status = (byte)reader["color_status"];
                        lstColor.Add(color);
                    }
                }
            }
            return lstColor;
        }

        public Color GetById(int id)
        {
            var color = new Color();
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from Colors where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        color.Id = (int)reader["id"];
                        color.Name = (string)reader["color_name"];
                        color.Value = (string)reader["color_value"];
                        color.Status = (byte)reader["color_status"];
                    }
                }
            }
            return color;
        }
        public void AddNew(Color color)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT Colors (color_name, color_value, color_status)" +
                    "Values (@color_name, @color_value, 1)";
                command.Parameters.Add("@color_name", SqlDbType.NVarChar).Value = color.Name;
                command.Parameters.Add("@color_value", SqlDbType.NVarChar).Value = color.Value;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Color color)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Colors 
                                        set color_name=@color_name,
                                            color_value= @color_value,
                                            color_status= 1
                                        where id=@id";
                command.Parameters.Add("@color_name", SqlDbType.NVarChar).Value = color.Name;
                command.Parameters.Add("@color_value", SqlDbType.NVarChar).Value = color.Value;
                 command.Parameters.Add("@id", SqlDbType.Int).Value = color.Id;
                command.ExecuteNonQuery();
            }
        }
        public void DeleteById(Color color)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Colors WHERE id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = color.Id;
                command.ExecuteNonQuery();
            }
        }

    }
}
