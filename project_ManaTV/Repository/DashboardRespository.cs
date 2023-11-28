using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project_ManaTV.Repository
{

	public class DashboardRespository
	{
		private readonly Database db = new Database();

		public int GetTotalOrder(DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");
			string query = "SELECT COUNT(id) AS total_bill FROM SellBill " +
			   "WHERE sell_date BETWEEN @fromDateStr AND @toDateStr";

			db.SetQuery(query);
			var res = db.LoadRow(fromDateStr, toDateStr);

			if (res != null && res.ContainsKey("total_bill"))
			{
				return Convert.ToInt32(res["total_bill"]);
			}

			return 0;
		}
		public decimal GetTotalPurchase(DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");

			string query = "SELECT SUM((ibd.import_amount * ibd.price) - ibd.import_voucher) AS total_purchase " +
			   "FROM ImportBillDetail ibd " +
			   "JOIN ImportBill ib ON ib.id = ibd.import_bill_id " +
			   "WHERE ib.import_date BETWEEN @fromDateStr AND @toDateStr";

			db.SetQuery(query);
			var res = db.LoadRow(fromDateStr, toDateStr);

			if (res != null && res.ContainsKey("total_purchase"))
			{
				return Convert.ToDecimal(res["total_purchase"]);
			}

			return 0;
		}
		public decimal GetTotalProfit(DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");

			string query = "SELECT SUM(sbd.sell_amount * sbd.price) AS total_profit " +
			   "FROM SellBillDetail sbd " +
			   "JOIN SellBill sb ON sbd.sell_bill_id = sb.id " +
			   "WHERE sb.sell_date BETWEEN @fromDateStr AND @toDateStr";
			db.SetQuery(query);
			var res = db.LoadRow(fromDateStr, toDateStr);

			if (res != null && res.ContainsKey("total_profit"))
			{
				return Convert.ToDecimal(res["total_profit"]);
			}

			return 0;
		}

		public List<Dictionary<string, object>> GetPurchaseDataInRange(DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");
			string query = $"SELECT * FROM GetPurchaseDataInRange(@fromDateStr, @toDateStr)";
			db.SetQuery(query);
			List<Dictionary<string, object>> resultRows = db.LoadAllRows(fromDate, toDate);

			return resultRows;
		}
		public List<Dictionary<string, object>> GetSellDataInRange(DateTime fromDate, DateTime toDate)
		{

			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");
			string query = $"SELECT * FROM GetSellDataInRange(@fromDateStr, @toDateStr)";
			db.SetQuery(query);
			List<Dictionary<string, object>> resultRows = db.LoadAllRows(fromDate, toDate);
			return resultRows;
		}
		public List<Dictionary<string, object>> GetTopSuppliersByDelivery(DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");
			string query = $"EXECUTE GetTopSuppliersByDelivery @fromDateStr, @toDateStr";
			db.SetQuery(query);
			List<Dictionary<string, object>> resultRows = db.LoadAllRows(fromDate, toDate);
			return resultRows;
		}
		public List<Dictionary<string, object>> GetListSellBillByDateRange(DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");
			string query = @"
				SELECT TOP 5
					SB.id AS sell_bill_id,
					SUM(SBD.sell_amount * SBD.price) AS sell_total,
					SB.sell_date,
					C.customer_name
				FROM
					SellBill SB
				JOIN
					SellBillDetail SBD ON SB.id = SBD.sell_bill_id	
				JOIN
					Customers C ON SB.customer_id = C.id
				WHERE
					SB.sell_date BETWEEN @fromDateStr AND @toDateStr
				GROUP BY
					SB.id, SB.sell_date, C.customer_name
				ORDER BY
					sell_total DESC";
			db.SetQuery(query);
			List<Dictionary<string, object>> resultRows = db.LoadAllRows(fromDateStr, toDateStr);
			return resultRows;
		}

		public List<Dictionary<string, object>> GetImportBillBySupplName(string suplierName,DateTime fromDate, DateTime toDate)
		{
			string fromDateStr = fromDate.ToString("yyyy-MM-dd");
			string toDateStr = toDate.ToString("yyyy-MM-dd");
			string supplyString = "1=1";
			if (suplierName != null) { supplyString = $" S.supplier_name = {suplierName}"; };
			string query = $@"
				SELECT 
					IB.id AS import_bill_id,
					IB.import_date,
					S.supplier_name,
					S.supplier_address,
					SUM(IBD.price * IBD.import_amount) AS import_total
				FROM
					ImportBill IB
				JOIN
					ImportBillDetail IBD ON IB.id = IBD.import_bill_id
				JOIN
					Supplier S ON IB.supplier_id = S.id
				WHERE
					{supplyString}
					AND IB.import_date BETWEEN @fromDateStr AND @toDateStr
				GROUP BY
					IB.id, IB.import_date, S.supplier_name, S.supplier_address";
			db.SetQuery(query);
			List<Dictionary<string, object>> resultRows = db.LoadAllRows(fromDateStr, toDateStr);
			return resultRows;
		}
	}
}

