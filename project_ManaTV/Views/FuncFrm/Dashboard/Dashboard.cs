
using LiveCharts.Wpf;
using LiveCharts;
using project_ManaTV.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.Dashboard
{
    public partial class Dashboard : Form
    {
        //Fields
        public Form FRM_LAYOUT { get; set; }
        private readonly DashboardRespository dashboardRepo;
        private Button currentButton;
		private DateTime startDate;
		private DateTime endDate;
		//Constructor
		public Dashboard()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.Font = SystemFonts.DefaultFont;
            dashboardRepo = new DashboardRespository();
            //Default - Last 7 days
            SetDateMenuButtonsUI(btnLast7Days);

			dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
        }
        private void UpdateUI()
        {
            string totalOrder = dashboardRepo.GetTotalOrder(dtpStartDate.Value, dtpEndDate.Value).ToString();
            string totalPurchase = dashboardRepo.GetTotalPurchase(dtpStartDate.Value, dtpEndDate.Value).ToString();
            string totalProfit = dashboardRepo.GetTotalProfit(dtpStartDate.Value, dtpEndDate.Value).ToString();

            lblNumOrders.Text = totalOrder;
            lblTotalPurchase.Text = totalPurchase;
            lblTotalProfit.Text = totalProfit;
            List<Dictionary<string, object>> listSuppierData = dashboardRepo.GetTopSuppliersByDelivery(dtpStartDate.Value, dtpEndDate.Value);
			chartTopSuplier.Series.Clear();

			System.Windows.Forms.DataVisualization.Charting.Series seriesPieChart = new System.Windows.Forms.DataVisualization.Charting.Series("Top Suppliers");
			seriesPieChart.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var row in listSuppierData)
            {
                string supplierName = row["supplier_name"].ToString();
                string address = row["supplier_address"].ToString();

                int deliveryCount = Convert.ToInt32(row["delivery_count"]);

                var dataPoint = seriesPieChart.Points.Add(deliveryCount);
                dataPoint.Label = deliveryCount.ToString();
                dataPoint.LegendText = $"{supplierName} - {address}";
                dataPoint.ToolTip = $"{supplierName} - {address}";
           
                dataPoint.IsValueShownAsLabel = false;
            }
            chartTopSuplier.Series.Add(seriesPieChart);

			List<Dictionary<string, object>> listPurchaseData = dashboardRepo.GetPurchaseDataInRange(dtpStartDate.Value, dtpEndDate.Value);
			List<Dictionary<string, object>> listSellData = dashboardRepo.GetSellDataInRange(dtpStartDate.Value, dtpEndDate.Value);

			SeriesCollection seriesLineChart = new SeriesCollection();
			List<double> sellData = new List<double>();
			foreach (var item in listSellData)
			{
				double amountMoney = Convert.ToDouble(item["total_sell"]);
				sellData.Add(amountMoney);
			}

			LineSeries sellSeries = new LineSeries
			{
				Title = "sell",
				Values = new ChartValues<double>(sellData)
			};

			List<double> purchaseData = new List<double>();
			foreach (var item in listPurchaseData)
			{
				double amountMoney = Convert.ToDouble(item["total_purchase"]);
				purchaseData.Add(amountMoney);
			}

			LineSeries purchaseSeries = new LineSeries
			{
				Title = "purcharse",
				Values = new ChartValues<double>(purchaseData)
			};
		
			seriesLineChart.Add(sellSeries);
			seriesLineChart.Add(purchaseSeries);
            chartGrossRevenue.Series = seriesLineChart;
			List<Dictionary<string, object>> listSellBill = dashboardRepo.GetListSellBillByDateRange(dtpStartDate.Value, dtpEndDate.Value);
            foreach (var item in listSellBill)
            {
                double total_sell = Convert.ToDouble(item["sell_total"]);
                DateTime sellDate = Convert.ToDateTime(item["sell_date"]);
                string customerName = Convert.ToString(item["customer_name"]);
                int sellBillId = Convert.ToInt32(item["sell_bill_id"]);
                dgvSellBill.Rows.Add(sellBillId, total_sell, sellDate, customerName);
            }
			List<Dictionary<string, object>> listImportBill = dashboardRepo.GetImportBillBySupplName(null,dtpStartDate.Value, dtpEndDate.Value);
			foreach (var item in listImportBill)
			{
				double total_import = Convert.ToDouble(item["import_total"]);
				DateTime importDate = Convert.ToDateTime(item["import_date"]);
				string suplierName = Convert.ToString(item["supplier_name"]);
                int importBillId = Convert.ToInt32(item["import_bill_id"]);
				string suplierAddress = Convert.ToString(item["supplier_address"]);
				dgvImportBill.Rows.Add(importBillId, total_import, importDate, suplierName, suplierAddress);
            }
            List<Dictionary<string, object>> listSupllier = dashboardRepo.GetAllSupplier();
            foreach (var item in listSupllier)
            {
                string supplier_name_address = Convert.ToString(item["supplier_name"]) + " - " + Convert.ToString(item["supplier_address"]);
				CbxSupplier.Items.Add(supplier_name_address);
			}


        }

        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;
            //Highlight button
            btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            //Unhighlight button
            if( currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn; //get current button
            if(btn == btnCustomDate)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOkCustomDate.Visible = true;
                lbStartDate.Cursor = Cursors.Hand;
                lbEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                DisableCustomDates();
                lbStartDate.Cursor = Cursors.Default;
                lbEndDate.Cursor = Cursors.Default;
            }

         }

        //Private methods
        private void LoadData()
        {

        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {

            SetDateMenuButtonsUI(sender);
        }



        private void lbStartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lbEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            if(currentButton == btnThisMonth || currentButton == btnLast30Days || currentButton == btnLast7Days || currentButton == btnToday)
            {
                return;
            }
            else
            {
				UpdateUI();
			}
		}

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lbEndDate.Text = dtpEndDate.Text;
			UpdateUI();
		}

		private void Form1_Load(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {

        }

		private void CbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
			dgvImportBill.Rows.Clear();
			string[] parts = this.CbxSupplier.SelectedItem.ToString().Split('-');
            string supplier_name = "";
			if (parts.Length > 1)
			{
				 supplier_name = parts[0].Trim();
			}
			List<Dictionary<string, object>> listImportBill = dashboardRepo.GetImportBillBySupplName(supplier_name, dtpStartDate.Value, dtpEndDate.Value);
			foreach (var item in listImportBill)
			{
				double total_import = Convert.ToDouble(item["import_total"]);
				DateTime importDate = Convert.ToDateTime(item["import_date"]);
				string suplierName = Convert.ToString(item["supplier_name"]);
                int importBillId = Convert.ToInt32(item["import_bill_id"]);
                string suplierAddress = Convert.ToString(item["supplier_address"]);
				dgvImportBill.Rows.Add(importBillId, total_import, importDate, suplierName, suplierAddress);
			}
		}
    }
}
