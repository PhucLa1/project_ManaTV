using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Repository
{

    public class DashboardRespository
    {
        private readonly Database db = new Database();
        public int GetTotalProductQuantity()
        {
            int totalQuantity = 0;

            using (var connection = new SqlConnection(db.ConnectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT SUM(product_amount) AS total_quantity FROM Products";

                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalQuantity = Convert.ToInt32(result);
                }
            }

            return totalQuantity;
        }
        public Dictionary<string, object> GetPurchaseSummary(DateTime fromDate, DateTime toDate)
        {
            Dictionary<string, object> summary = new Dictionary<string, object>();

            try
            {
                using (var connection = new SqlConnection(db.ConnectionString))
                using (var command = new SqlCommand("SELECT * FROM dbo.GetPurchaseSummary(@fromDate, @toDate)", connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            summary["TotalProducts"] = reader["total_products"];
                            summary["TotalPurchaseAmount"] = reader["total_purchase_amount"];
                            summary["TotalSuppliers"] = reader["total_suppliers"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return summary;
        }
        public Dictionary<string, decimal> GetPurchaseDataInRange(DateTime fromDate, DateTime toDate)
        {
            Dictionary<string, decimal> purchaseData = new Dictionary<string, decimal>();

            try
            {
                using (var connection = new SqlConnection(db.ConnectionString))
                using (var command = new SqlCommand("SELECT * FROM GetPurchaseDataInRange(@FromDate, @ToDate)", connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@FromDate", fromDate);
                    command.Parameters.AddWithValue("@ToDate", toDate);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string purchaseDate = reader["purchase_date"].ToString();
                            decimal totalPurchaseAmount = Convert.ToDecimal(reader["total_purchase_amount"]);
                            purchaseData.Add(purchaseDate, totalPurchaseAmount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây nếu cần
                Console.WriteLine("Error: " + ex.Message);
            }

            return purchaseData;
        }
        public DataTable GetTopSuppliersByDeliveryCount(DateTime startDate, DateTime endDate)
        {
            DataTable topSuppliers = new DataTable();

            try
            {
                using (var connection = new SqlConnection(db.ConnectionString))
                using (var command = new SqlCommand("GetTop5SuppliersByDelivery", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@start_date", startDate);
                    command.Parameters.AddWithValue("@end_date", endDate);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(topSuppliers);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây nếu cần
                Console.WriteLine("Error: " + ex.Message);
            }

            return topSuppliers;
        }

        public DataTable GetInvoiceDetails(DateTime fromDate, DateTime toDate)
        {
            DataTable invoiceDetails = new DataTable();

            try
            {
                using (var connection = new SqlConnection(db.ConnectionString))
                using (var command = new SqlCommand("GetInvoiceDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@endDate", toDate);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(invoiceDetails);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây nếu cần
                Console.WriteLine("Error: " + ex.Message);
            }

            return invoiceDetails;
        }
    }
}

