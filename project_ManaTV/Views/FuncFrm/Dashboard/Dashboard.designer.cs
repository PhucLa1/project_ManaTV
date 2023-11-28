
namespace project_ManaTV.Views.FuncFrm.Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.btnThisMonth = new System.Windows.Forms.Button();
			this.btnLast30Days = new System.Windows.Forms.Button();
			this.btnLast7Days = new System.Windows.Forms.Button();
			this.btnToday = new System.Windows.Forms.Button();
			this.btnCustomDate = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNumOrders = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblTotalPurchase = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.lblTotalProfit = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.chartTopSuplier = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgvSellBill = new System.Windows.Forms.DataGridView();
			this.sell_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sell_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sell_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.lbStartDate = new System.Windows.Forms.Label();
			this.lbEndDate = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnOkCustomDate = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.CbxSupplier = new System.Windows.Forms.ComboBox();
			this.dgvImportBill = new System.Windows.Forms.DataGridView();
			this.import_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.import_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.import_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.suplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
			this.chartGrossRevenue = new LiveCharts.WinForms.CartesianChart();
			this.colorsTableAdapter1 = new project_ManaTV.TVManagementDataSetTableAdapters.ColorsTableAdapter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTopSuplier)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSellBill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnOkCustomDate)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvImportBill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dashboard";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
			this.dtpStartDate.Enabled = false;
			this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDate.Location = new System.Drawing.Point(211, 18);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(122, 23);
			this.dtpStartDate.TabIndex = 1;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
			this.dtpEndDate.Enabled = false;
			this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndDate.Location = new System.Drawing.Point(357, 18);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(122, 23);
			this.dtpEndDate.TabIndex = 2;
			this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
			// 
			// btnThisMonth
			// 
			this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
			this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.btnThisMonth.Location = new System.Drawing.Point(1060, 10);
			this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
			this.btnThisMonth.Name = "btnThisMonth";
			this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
			this.btnThisMonth.TabIndex = 3;
			this.btnThisMonth.Text = "This month";
			this.btnThisMonth.UseVisualStyleBackColor = true;
			this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
			// 
			// btnLast30Days
			// 
			this.btnLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
			this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.btnLast30Days.Location = new System.Drawing.Point(929, 10);
			this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
			this.btnLast30Days.Name = "btnLast30Days";
			this.btnLast30Days.Size = new System.Drawing.Size(130, 35);
			this.btnLast30Days.TabIndex = 4;
			this.btnLast30Days.Text = "Last 30 days";
			this.btnLast30Days.UseVisualStyleBackColor = true;
			this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
			// 
			// btnLast7Days
			// 
			this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
			this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.btnLast7Days.Location = new System.Drawing.Point(798, 10);
			this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
			this.btnLast7Days.Name = "btnLast7Days";
			this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
			this.btnLast7Days.TabIndex = 5;
			this.btnLast7Days.Text = "Lasts 7 days";
			this.btnLast7Days.UseVisualStyleBackColor = true;
			this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
			// 
			// btnToday
			// 
			this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
			this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.btnToday.Location = new System.Drawing.Point(667, 10);
			this.btnToday.Margin = new System.Windows.Forms.Padding(5);
			this.btnToday.Name = "btnToday";
			this.btnToday.Size = new System.Drawing.Size(130, 35);
			this.btnToday.TabIndex = 6;
			this.btnToday.Text = "Today";
			this.btnToday.UseVisualStyleBackColor = true;
			this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
			// 
			// btnCustomDate
			// 
			this.btnCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
			this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.btnCustomDate.Location = new System.Drawing.Point(538, 10);
			this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
			this.btnCustomDate.Name = "btnCustomDate";
			this.btnCustomDate.Size = new System.Drawing.Size(130, 35);
			this.btnCustomDate.TabIndex = 7;
			this.btnCustomDate.Text = "Custom";
			this.btnCustomDate.UseVisualStyleBackColor = true;
			this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblNumOrders);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(14, 55);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(278, 73);
			this.panel1.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(59, 57);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label3.Location = new System.Drawing.Point(221, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "+15%";
			// 
			// lblNumOrders
			// 
			this.lblNumOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNumOrders.AutoSize = true;
			this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumOrders.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblNumOrders.Location = new System.Drawing.Point(60, 39);
			this.lblNumOrders.Name = "lblNumOrders";
			this.lblNumOrders.Size = new System.Drawing.Size(27, 29);
			this.lblNumOrders.TabIndex = 1;
			this.lblNumOrders.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label2.Location = new System.Drawing.Point(59, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Number of Orders";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.lblTotalPurchase);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(302, 55);
			this.panel2.Margin = new System.Windows.Forms.Padding(5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(458, 73);
			this.panel2.TabIndex = 10;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 10);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(59, 57);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label10.Location = new System.Drawing.Point(399, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 25);
			this.label10.TabIndex = 3;
			this.label10.Text = "+21%";
			// 
			// lblTotalPurchase
			// 
			this.lblTotalPurchase.AutoSize = true;
			this.lblTotalPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalPurchase.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTotalPurchase.Location = new System.Drawing.Point(76, 39);
			this.lblTotalPurchase.Name = "lblTotalPurchase";
			this.lblTotalPurchase.Size = new System.Drawing.Size(27, 29);
			this.lblTotalPurchase.TabIndex = 1;
			this.lblTotalPurchase.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label4.Location = new System.Drawing.Point(76, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Total Purchase ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.lblTotalProfit);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(770, 55);
			this.panel3.Margin = new System.Windows.Forms.Padding(5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(420, 73);
			this.panel3.TabIndex = 11;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(11, 9);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(59, 57);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label11.Location = new System.Drawing.Point(361, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 25);
			this.label11.TabIndex = 3;
			this.label11.Text = "+19%";
			// 
			// lblTotalProfit
			// 
			this.lblTotalProfit.AutoSize = true;
			this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalProfit.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTotalProfit.Location = new System.Drawing.Point(75, 39);
			this.lblTotalProfit.Name = "lblTotalProfit";
			this.lblTotalProfit.Size = new System.Drawing.Size(27, 29);
			this.lblTotalProfit.TabIndex = 1;
			this.lblTotalProfit.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label5.Location = new System.Drawing.Point(75, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Total Profit";
			// 
			// chartTopSuplier
			// 
			this.chartTopSuplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			chartArea1.Name = "ChartArea1";
			this.chartTopSuplier.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			legend1.ForeColor = System.Drawing.Color.Gainsboro;
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			this.chartTopSuplier.Legends.Add(legend1);
			this.chartTopSuplier.Location = new System.Drawing.Point(870, 138);
			this.chartTopSuplier.Margin = new System.Windows.Forms.Padding(5);
			this.chartTopSuplier.Name = "chartTopSuplier";
			this.chartTopSuplier.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chartTopSuplier.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
			series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
			series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
			series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			series1.BorderWidth = 8;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			series1.IsValueShownAsLabel = true;
			series1.LabelForeColor = System.Drawing.Color.White;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartTopSuplier.Series.Add(series1);
			this.chartTopSuplier.Size = new System.Drawing.Size(320, 255);
			this.chartTopSuplier.TabIndex = 13;
			this.chartTopSuplier.Text = "chartTopSuplier";
			title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			title1.ForeColor = System.Drawing.Color.WhiteSmoke;
			title1.Name = "Title1";
			title1.Text = "5 Best selling products";
			this.chartTopSuplier.Titles.Add(title1);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.panel5.Controls.Add(this.dgvSellBill);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.pictureBox7);
			this.panel5.Location = new System.Drawing.Point(19, 403);
			this.panel5.Margin = new System.Windows.Forms.Padding(5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1176, 318);
			this.panel5.TabIndex = 11;
			// 
			// dgvSellBill
			// 
			this.dgvSellBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSellBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.dgvSellBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSellBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSellBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSellBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSellBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSellBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sell_bill_id,
            this.sell_total,
            this.sell_date,
            this.customer_name});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSellBill.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSellBill.EnableHeadersVisualStyles = false;
			this.dgvSellBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
			this.dgvSellBill.Location = new System.Drawing.Point(30, 45);
			this.dgvSellBill.Name = "dgvSellBill";
			this.dgvSellBill.RowHeadersVisible = false;
			this.dgvSellBill.RowHeadersWidth = 51;
			this.dgvSellBill.RowTemplate.Height = 35;
			this.dgvSellBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSellBill.Size = new System.Drawing.Size(1123, 238);
			this.dgvSellBill.TabIndex = 3;
			// 
			// sell_bill_id
			// 
			this.sell_bill_id.HeaderText = "id";
			this.sell_bill_id.MinimumWidth = 6;
			this.sell_bill_id.Name = "sell_bill_id";
			this.sell_bill_id.ReadOnly = true;
			// 
			// sell_total
			// 
			this.sell_total.HeaderText = "sell total";
			this.sell_total.MinimumWidth = 6;
			this.sell_total.Name = "sell_total";
			this.sell_total.ReadOnly = true;
			// 
			// sell_date
			// 
			this.sell_date.HeaderText = "sell date";
			this.sell_date.MinimumWidth = 6;
			this.sell_date.Name = "sell_date";
			this.sell_date.ReadOnly = true;
			// 
			// customer_name
			// 
			this.customer_name.HeaderText = "customer name";
			this.customer_name.MinimumWidth = 6;
			this.customer_name.Name = "customer_name";
			this.customer_name.ReadOnly = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label13.Location = new System.Drawing.Point(10, 10);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(171, 29);
			this.label13.TabIndex = 2;
			this.label13.Text = "Excellent staff";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(1123, 10);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(30, 30);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 3;
			this.pictureBox7.TabStop = false;
			// 
			// lbStartDate
			// 
			this.lbStartDate.AutoSize = true;
			this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.lbStartDate.Location = new System.Drawing.Point(208, 14);
			this.lbStartDate.MinimumSize = new System.Drawing.Size(130, 0);
			this.lbStartDate.Name = "lbStartDate";
			this.lbStartDate.Size = new System.Drawing.Size(130, 25);
			this.lbStartDate.TabIndex = 0;
			this.lbStartDate.Click += new System.EventHandler(this.lbStartDate_Click);
			// 
			// lbEndDate
			// 
			this.lbEndDate.AutoSize = true;
			this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.lbEndDate.Location = new System.Drawing.Point(353, 14);
			this.lbEndDate.MinimumSize = new System.Drawing.Size(130, 0);
			this.lbEndDate.Name = "lbEndDate";
			this.lbEndDate.Size = new System.Drawing.Size(130, 25);
			this.lbEndDate.TabIndex = 0;
			this.lbEndDate.Click += new System.EventHandler(this.lbEndDate_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			this.label12.Location = new System.Drawing.Point(335, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(19, 25);
			this.label12.TabIndex = 0;
			this.label12.Text = "-";
			// 
			// btnOkCustomDate
			// 
			this.btnOkCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
			this.btnOkCustomDate.Image = ((System.Drawing.Image)(resources.GetObject("btnOkCustomDate.Image")));
			this.btnOkCustomDate.Location = new System.Drawing.Point(501, 10);
			this.btnOkCustomDate.Name = "btnOkCustomDate";
			this.btnOkCustomDate.Size = new System.Drawing.Size(33, 35);
			this.btnOkCustomDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnOkCustomDate.TabIndex = 3;
			this.btnOkCustomDate.TabStop = false;
			this.btnOkCustomDate.Visible = false;
			this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.panel6.Controls.Add(this.CbxSupplier);
			this.panel6.Controls.Add(this.dgvImportBill);
			this.panel6.Controls.Add(this.label14);
			this.panel6.Controls.Add(this.pictureBox8);
			this.panel6.Location = new System.Drawing.Point(19, 731);
			this.panel6.Margin = new System.Windows.Forms.Padding(5);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1176, 318);
			this.panel6.TabIndex = 14;
			// 
			// CbxSupplier
			// 
			this.CbxSupplier.FormattingEnabled = true;
			this.CbxSupplier.Location = new System.Drawing.Point(869, 9);
			this.CbxSupplier.Name = "CbxSupplier";
			this.CbxSupplier.Size = new System.Drawing.Size(229, 28);
			this.CbxSupplier.TabIndex = 4;
			this.CbxSupplier.SelectedIndexChanged += new System.EventHandler(this.CbxSupplier_SelectedIndexChanged);
			// 
			// dgvImportBill
			// 
			this.dgvImportBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvImportBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.dgvImportBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvImportBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvImportBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvImportBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvImportBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvImportBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.import_bill_id,
            this.import_total,
            this.import_date,
            this.suplier_name,
            this.supplier_address});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvImportBill.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvImportBill.EnableHeadersVisualStyles = false;
			this.dgvImportBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
			this.dgvImportBill.Location = new System.Drawing.Point(15, 45);
			this.dgvImportBill.Name = "dgvImportBill";
			this.dgvImportBill.RowHeadersVisible = false;
			this.dgvImportBill.RowHeadersWidth = 51;
			this.dgvImportBill.RowTemplate.Height = 35;
			this.dgvImportBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvImportBill.Size = new System.Drawing.Size(1138, 240);
			this.dgvImportBill.TabIndex = 3;
			// 
			// import_bill_id
			// 
			this.import_bill_id.HeaderText = "id";
			this.import_bill_id.MinimumWidth = 6;
			this.import_bill_id.Name = "import_bill_id";
			this.import_bill_id.ReadOnly = true;
			// 
			// import_total
			// 
			this.import_total.HeaderText = "import total";
			this.import_total.MinimumWidth = 6;
			this.import_total.Name = "import_total";
			this.import_total.ReadOnly = true;
			// 
			// import_date
			// 
			this.import_date.HeaderText = "import date";
			this.import_date.MinimumWidth = 6;
			this.import_date.Name = "import_date";
			this.import_date.ReadOnly = true;
			// 
			// suplier_name
			// 
			this.suplier_name.HeaderText = "suplier_name";
			this.suplier_name.MinimumWidth = 6;
			this.suplier_name.Name = "suplier_name";
			this.suplier_name.ReadOnly = true;
			// 
			// supplier_address
			// 
			this.supplier_address.HeaderText = "supplier address";
			this.supplier_address.MinimumWidth = 6;
			this.supplier_address.Name = "supplier_address";
			this.supplier_address.ReadOnly = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label14.Location = new System.Drawing.Point(10, 10);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(171, 29);
			this.label14.TabIndex = 2;
			this.label14.Text = "Excellent staff";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(1123, 9);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(30, 30);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 3;
			this.pictureBox8.TabStop = false;
			// 
			// bunifuVScrollBar1
			// 
			this.bunifuVScrollBar1.AllowCursorChanges = true;
			this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
			this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
			this.bunifuVScrollBar1.AllowMouseDownEffects = true;
			this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
			this.bunifuVScrollBar1.AllowScrollingAnimations = true;
			this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
			this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
			this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
			this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
			this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
			this.bunifuVScrollBar1.BindingContainer = this;
			this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
			this.bunifuVScrollBar1.BorderRadius = 14;
			this.bunifuVScrollBar1.BorderThickness = 1;
			this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
			this.bunifuVScrollBar1.LargeChange = 10;
			this.bunifuVScrollBar1.Location = new System.Drawing.Point(1200, 9);
			this.bunifuVScrollBar1.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuVScrollBar1.Maximum = 100;
			this.bunifuVScrollBar1.Minimum = 0;
			this.bunifuVScrollBar1.MinimumThumbLength = 18;
			this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
			this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
			this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
			this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
			this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.Silver;
			this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.Silver;
			this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
			this.bunifuVScrollBar1.Size = new System.Drawing.Size(10, 200);
			this.bunifuVScrollBar1.SmallChange = 1;
			this.bunifuVScrollBar1.TabIndex = 4;
			this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
			this.bunifuVScrollBar1.ThumbLength = 19;
			this.bunifuVScrollBar1.ThumbMargin = 1;
			this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
			this.bunifuVScrollBar1.Value = 0;
			// 
			// chartGrossRevenue
			// 
			this.chartGrossRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
			this.chartGrossRevenue.Location = new System.Drawing.Point(14, 138);
			this.chartGrossRevenue.Name = "chartGrossRevenue";
			this.chartGrossRevenue.Size = new System.Drawing.Size(837, 255);
			this.chartGrossRevenue.TabIndex = 15;
			this.chartGrossRevenue.Text = "cartesianChart";
			// 
			// colorsTableAdapter1
			// 
			this.colorsTableAdapter1.ClearBeforeFill = true;
			// 
			// Dashboard
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(1204, 730);
			this.Controls.Add(this.chartGrossRevenue);
			this.Controls.Add(this.bunifuVScrollBar1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.btnOkCustomDate);
			this.Controls.Add(this.lbEndDate);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lbStartDate);
			this.Controls.Add(this.chartTopSuplier);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCustomDate);
			this.Controls.Add(this.btnToday);
			this.Controls.Add(this.btnLast7Days);
			this.Controls.Add(this.btnLast30Days);
			this.Controls.Add(this.btnThisMonth);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Dashboard";
			this.Text = "Store statistics";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTopSuplier)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSellBill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnOkCustomDate)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvImportBill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPurchase ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSuplier;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvSellBill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox btnOkCustomDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvImportBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
		private LiveCharts.WinForms.CartesianChart chartGrossRevenue;
		private System.Windows.Forms.DataGridViewTextBoxColumn sell_bill_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn sell_total;
		private System.Windows.Forms.DataGridViewTextBoxColumn sell_date;
		private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn import_bill_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn import_total;
		private System.Windows.Forms.DataGridViewTextBoxColumn import_date;
		private System.Windows.Forms.DataGridViewTextBoxColumn suplier_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplier_address;
		private TVManagementDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter1;
		private System.Windows.Forms.ComboBox CbxSupplier;
	}
}