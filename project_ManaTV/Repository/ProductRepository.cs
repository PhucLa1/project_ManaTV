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
    public class ProductRepository
    {
        Database db = new Database();

        public List<ProductViewModel> GetAll()
        {
            var lstProduct = new List<ProductViewModel>();
            
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from vwProduct";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductViewModel();
                        product.Id = (int)reader["id"];
                        product.Name = reader["product_name"].ToString();
                        product.ManufacturerName = reader["manufacturer_name"].ToString();
                        product.DesignName = reader["design_name"].ToString();
                        product.ColorName = reader["color_name"].ToString();
                        product.ScreenName = reader["screen_name"].ToString();
                        product.SizeName = reader["screen_size"].ToString();
                        product.CountryName = reader["country_name"].ToString();
                        product.ProductAmount = (int)reader["product_amount"];
                        product.ProductSellMoney = (int)reader["product_sell_money"];
                        product.ProductImportMoney = (int)reader["product_import_money"];
                        product.IsDeleted = (bool)reader["isDeleted"];

                        product.ManufacturerId = (int)reader["manufacturer_id"];
                        product.DesignId = (int)reader["design_id"];
                        product.ColorId = (int)reader["color_id"];
                        product.ScreenId = (int)reader["screen_id"];
                        product.SizeId = (int)reader["size_id"];
                        product.CountryId = (int)reader["country_id"];
                        lstProduct.Add(product);
                    }
                }
            }
            return lstProduct;
        }

        public ProductViewModel GetById(int id)
        {
            var product = new ProductViewModel();

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from vwProduct where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product.Id = (int)reader["id"];
                        product.Name = reader["product_name"].ToString();
                        product.ManufacturerName = reader["manufacturer_name"].ToString();
                        product.DesignName = reader["design_name"].ToString();
                        product.ColorName = reader["color_name"].ToString();
                        product.ScreenName = reader["screen_name"].ToString();
                        product.SizeName = reader["screen_size"].ToString();
                        product.CountryName = reader["country_name"].ToString();
                        product.ProductAmount = (int)reader["product_amount"];
                        product.ProductImportMoney = (int)reader["product_import_money"];
                        product.ProductSellMoney = (int)reader["product_sell_money"];
                        product.IsDeleted = (bool)reader["isDeleted"];

                        product.ManufacturerId = (int)reader["manufacturer_id"];
                        product.DesignId = (int)reader["design_id"];
                        product.ColorId = (int)reader["color_id"];
                        product.ScreenId = (int)reader["screen_id"];
                        product.SizeId = (int)reader["size_id"];
                        product.CountryId = (int)reader["country_id"];
                    }
                }
            }
            return product;
        }

        public void AddNew(Product product)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Products(product_name, manufacturer_id, design_id, color_id, screen_id, size_id, country_id, product_amount, product_import_money,isDeleted) " +
                                        "values (@product_name, @manufacturer_id, @design_id, @color_id, @screen_id, @size_id, @country_id, @product_amount, @product_import_money, 0)";
                command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = product.Name;
                command.Parameters.Add("@manufacturer_id", SqlDbType.Int).Value = product.ManufacturerId;
                command.Parameters.Add("@design_id", SqlDbType.Int).Value = product.DesignId;
                command.Parameters.Add("@color_id", SqlDbType.Int).Value = product.ColorId;
                command.Parameters.Add("@screen_id", SqlDbType.Int).Value = product.ScreenId;
                command.Parameters.Add("@size_id", SqlDbType.Int).Value = product.SizeId;
                command.Parameters.Add("@country_id", SqlDbType.Int).Value = product.CountryId;
                command.Parameters.Add("@product_amount", SqlDbType.Int).Value = product.ProductAmount;
                command.Parameters.Add("@product_import_money", SqlDbType.Int).Value = product.ProductImportMoney;
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
                command.CommandText = "DELETE Products where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void SetDeleteStatus(int id, bool status)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Products SET isDeleted = @status where id=@id";
                command.Parameters.Add("@status", SqlDbType.Bit).Value = status?1:0;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Product product)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Products 
                                        set product_name=@product_name,
                                            manufacturer_id= @manufacturer_id,
                                            design_id= @design_id,
                                            color_id= @color_id,
                                            screen_id= @screen_id,
                                            size_id= @size_id,
                                            country_id= @country_id,
                                            product_amount= @product_amount,
                                            product_import_money= @product_import_money
                                        where id=@id";
                command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = product.Name;
                command.Parameters.Add("@manufacturer_id", SqlDbType.Int).Value = product.ManufacturerId;
                command.Parameters.Add("@design_id", SqlDbType.Int).Value = product.DesignId;
                command.Parameters.Add("@color_id", SqlDbType.Int).Value = product.ColorId;
                command.Parameters.Add("@screen_id", SqlDbType.Int).Value = product.ScreenId;
                command.Parameters.Add("@size_id", SqlDbType.Int).Value = product.SizeId;
                command.Parameters.Add("@country_id", SqlDbType.Int).Value = product.CountryId;
                command.Parameters.Add("@product_amount", SqlDbType.Int).Value = product.ProductAmount;
                command.Parameters.Add("@product_import_money", SqlDbType.Int).Value = product.ProductImportMoney;
                command.Parameters.Add("@id", SqlDbType.Int).Value = product.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
