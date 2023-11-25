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
    public class DesignRepository
    {
        Database db = new Database();

        public List<Design> GetAll()
        {
            var lstDesign = new List<Design>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Designs";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Design = new Design();
                        Design.Id = (int)reader["id"];
                        Design.Name = reader["design_name"].ToString();
                        lstDesign.Add(Design);
                    }
                }
            }
            return lstDesign;
        }

        public Design GetById(int id)
        {
            var Design = new Design();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from Designs where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Design.Id = (int)reader["id"];
                        Design.Name = reader["design_name"].ToString();
                    }
                }
            }
            return Design;
        }

        public void AddNew(Design Design)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Designs(design_name) " +
                                        "values (@design_name)";
                command.Parameters.Add("@design_name", SqlDbType.NVarChar).Value = Design.Name;
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
                command.CommandText = "DELETE Designs where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Design customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Designs 
                                        set design_name=@design_name
                                        where id=@id";
                command.Parameters.Add("@design_name", SqlDbType.NVarChar).Value = customer.Name;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
