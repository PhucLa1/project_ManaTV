using project_ManaTV.Models;
using project_ManaTV.TVManagementDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Repository
{
    public class OriginRepository
    {
        Database db = new Database();

        public List<Origin> GetAll()
        {
            var lstOrogin = new List<Origin>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from CountryOfManufacture";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var origin = new Origin();
                        origin.Id = (int)reader["id"];
                        origin.Name = reader["country_name"].ToString();
                        lstOrogin.Add(origin);
                    }
                }
            }
            return lstOrogin;
        }

        public Origin GetById(int id)
        {
            var origin = new Origin();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from CountryOfManufacture where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        origin.Id = (int)reader["id"];
                        origin.Name = reader["country_name"].ToString();
                    }
                }
            }
            return origin;
        }

        public void AddNew(Origin origin)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert CountryOfManufacture(country_name) " +
                                        "values (@country_name)";
                command.Parameters.Add("@country_name", SqlDbType.NVarChar).Value = origin.Name;
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
                command.CommandText = "DELETE CountryOfManufacture where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Origin customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update CountryOfManufacture
                                        set country_name=@country_name,
                                        where id=@id";
                command.Parameters.Add("@country_name", SqlDbType.NVarChar).Value = customer.Name;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
