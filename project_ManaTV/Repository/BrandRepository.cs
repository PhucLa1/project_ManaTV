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
    public class BrandRepository
    {
        Database db = new Database();

        public List<Brand> GetAll()
        {
            var lstBrand = new List<Brand>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Manufacturer";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var brand = new Brand();
                        brand.Id = (int)reader["id"];
                        brand.Name = reader["manufacturer_name"].ToString();
                        brand.Address = reader["manufacturer_address"].ToString();
                        lstBrand.Add(brand);
                    }
                }
            }
            return lstBrand;
        }

        public Brand GetById(int id)
        {
            var brand = new Brand();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from Manufacturer where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        brand.Id = (int)reader["id"];
                        brand.Name = reader["manufacturer_name"].ToString();
                        brand.Address = reader["manufacturer_address"].ToString();
                    }
                }
            }
            return brand;
        }

        public void AddNew(Brand brand)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Manufacturer(manufacturer_name, manufacturer_address) " +
                                        "values (@manufacturer_name, @manufacturer_address)";
                command.Parameters.Add("@manufacturer_name", SqlDbType.NVarChar).Value = brand.Name;
                command.Parameters.Add("@manufacturer_address", SqlDbType.NVarChar).Value = brand.Address;
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
                command.CommandText = "DELETE Manufacturer where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Brand customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Manufacturer 
                                        set manufacturer_name=@manufacturer_name,
                                            manufacturer_address= @manufacturer_address
                                        where id=@id";
                command.Parameters.Add("@manufacturer_name", SqlDbType.NVarChar).Value = customer.Name;
                command.Parameters.Add("@manufacturer_address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
