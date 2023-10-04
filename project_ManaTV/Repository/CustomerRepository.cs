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
    public class CustomerRepository
    {
        Database db = new Database();

        public IEnumerable<Customer> GetAll()
        {
            var lstCustomer = new List<Customer>();
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Customers";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new Customer();
                        customer.Id = (int)reader["id"];
                        customer.FullName = reader["customer_name"].ToString();
                        customer.Address = reader["customer_address"].ToString();
                        customer.PhoneNumber = reader["customer_phoneNumber"].ToString();
                        customer.Email = reader["customer_email"].ToString();
                        lstCustomer.Add(customer);
                    }
                }
            }
            return lstCustomer;
        }

        public Customer GetById(int id)
        {
            var customer = new Customer();
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"Select * from Customers where id = {id}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customer.Id = (int)reader["id"];
                        customer.FullName = reader["customer_name"].ToString();
                        customer.Address = reader["customer_address"].ToString();
                        customer.PhoneNumber = reader["customer_phoneNumber"].ToString();
                        customer.Email = reader["customer_email"].ToString();
                    }
                }
            }
            return customer;
        }

        public void AddNew(Customer customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert Customers(customer_name, customer_email, customer_address, customer_phoneNumber, createdAt) " +
                                        "values (@customer_name, @customer_email, @customer_address, @customer_phoneNumber, @createdAt)";
                command.Parameters.Add("@customer_name", SqlDbType.NVarChar).Value = customer.FullName;
                command.Parameters.Add("@customer_email", SqlDbType.NVarChar).Value = customer.Email;
                command.Parameters.Add("@customer_address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.Add("@customer_phoneNumber", SqlDbType.NVarChar).Value = customer.PhoneNumber;
                command.Parameters.Add("@createdAt", SqlDbType.DateTime).Value = DateTime.Now;
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
                command.CommandText = "delete Customers Pet where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Customer customer)
        {
            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Customers 
                                        set customer_name=@customer_name,
                                            customer_email= @customer_email,
                                            customer_address= @customer_address,
                                            customer_phoneNumber= @customer_phoneNumber,
                                            updatedAt = @updatedAt
                                        where id=@id";
                command.Parameters.Add("@customer_name", SqlDbType.NVarChar).Value = customer.FullName;
                command.Parameters.Add("@customer_email", SqlDbType.NVarChar).Value = customer.Email;
                command.Parameters.Add("@customer_address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.Add("@customer_phoneNumber", SqlDbType.NVarChar).Value = customer.PhoneNumber;
                command.Parameters.Add("@updatedAt", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.ExecuteNonQuery();
            }
        }


    }
}
