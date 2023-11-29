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
    public class ProductImageRepository
    {
        Database db = new Database();

        public List<ProductImage> GetAll()
        {
            var lstProductImage = new List<ProductImage>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Images";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productImage = new ProductImage();
                        productImage.Id = (int)reader["id"];
                        productImage.ProductId = (int)reader["product_id"];
                        productImage.ImagePath = reader["image_path"].ToString();
                        lstProductImage.Add(productImage);
                    }
                }
            }
            return lstProductImage;
        }

        public ProductImage GetById(int id)
        {
            var productImage = new ProductImage();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from Images where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productImage.Id = (int)reader["id"];
                        productImage.ProductId = (int)reader["product_id"];
                        productImage.ImagePath = reader["image_path"].ToString();
                    }
                }
            }
            return productImage;
        }

        public void AddNew(ProductImage productImage)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Images(product_id, image_path) " +
                                        "values (@product_id, @image_path)";
                command.Parameters.Add("@product_id", SqlDbType.Int).Value = productImage.ProductId;
                command.Parameters.Add("@image_path", SqlDbType.NVarChar).Value = productImage.ImagePath;
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
                command.CommandText = "DELETE Images where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteByProductId(int productId)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE Images where product_id=@productId";
                command.Parameters.Add("@productId", SqlDbType.Int).Value = productId;
                command.ExecuteNonQuery();
            }
        }

        public void Update(ProductImage customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Images 
                                        set product_id=@product_id,
                                            image_path= @image_path
                                        where id=@id";
                command.Parameters.Add("@product_id", SqlDbType.Int).Value = customer.ProductId;
                command.Parameters.Add("@image_path", SqlDbType.NVarChar).Value = customer.ImagePath;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
