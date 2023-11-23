using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using project_ManaTV.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Repository
{
    public class DesignRepository
    {
        Database db = new Database();

        public List<Designs> GetAll()
        {
            var lstDesign = new List<Designs>();
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
                        var design = new Designs();
                        design.Id = (int)reader["id"];
                        design.Name = (string)reader["design_name"];
                        design.Status = (byte)reader["design_status"];
                        lstDesign.Add(design);
                    }
                }
            }
            return lstDesign;
        }

        public Designs GetById(int id)
        {
            var design = new Designs();
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
                        design.Id = (int)reader["id"];
                        design.Name = (string)reader["design_name"];
                        design.Status = (byte)reader["design_status"];
                    }
                }
            }
            return design;
        }
        public void AddNew(Designs design)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT Designs (design_name, design_status)" +
                    "Values (@design_name, 1)";
                command.Parameters.Add("@design_name", SqlDbType.NVarChar).Value = design.Name;
                command.Parameters.Add("@design_status", SqlDbType.NVarChar).Value = design.Status;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Designs design)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Designs 
                                        set design_name=@design_name,
                                            design_status= 1
                                        where id=@id";
                command.Parameters.Add("@design_name", SqlDbType.NVarChar).Value = design.Name;
                command.Parameters.Add("@id", SqlDbType.Int).Value = design.Id;
                command.ExecuteNonQuery();
            }
        }
        public void DeleteById(Designs design)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Designs WHERE id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = design.Id;
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
                command.CommandText = "DELETE FROM Designs WHERE id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
    }
}
