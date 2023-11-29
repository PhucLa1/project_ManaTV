using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms;
using project_ManaTV.HelpMethod;
using project_ManaTV.Repository;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace project_ManaTV.Views.FuncFrm.Bill
{
    public partial class BillDataTable : Form
    {
        public Form FRM_LAYOUT { get; set; }//thêm FRM_Layout
        private int CurrentPage = 1;
        private int PageSize = 10;
        private int TotalPage;
        private int TotalRows;
        public int currentPage
        {
            get { return CurrentPage; }
            set { CurrentPage = value; }
        }
        public int pageSize
        {
            get { return PageSize; }
            set { PageSize = value; }
        }

        public int totalPages
        {
            get { return TotalPage; }
            set { TotalPage = value; }
        }
        public int totalRows
        {
            get { return TotalRows; }
            set { TotalRows = value; }
        }

        // 0 : sell 1 : import
        public BillDataTable(int _status)
        {
            status = _status;
            InitializeComponent();
            //Setup header color
            Color alterHeaderColor = Color.FromArgb(40, 96, 144);
            SellBillGrid.ColumnHeadersDefaultCellStyle.BackColor = alterHeaderColor;
            SellBillGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            SellBillGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = alterHeaderColor;
            SellBillGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            ImportBillGrid.ColumnHeadersDefaultCellStyle.BackColor = alterHeaderColor;
            ImportBillGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            ImportBillGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = alterHeaderColor;
            ImportBillGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //Setup Row Color
            Color alterRowColor = Color.FromArgb(224, 224, 224);
            SellBillGrid.AlternatingRowsDefaultCellStyle.BackColor = alterRowColor;
            SellBillGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.Empty;
            SellBillGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = alterRowColor;
            SellBillGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Empty;

            ImportBillGrid.AlternatingRowsDefaultCellStyle.BackColor = alterRowColor;
            ImportBillGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.Empty;
            ImportBillGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = alterRowColor;
            ImportBillGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Empty;
            //Setup Cell Color
            Color alterFontColor = Color.FromArgb(64, 64, 64);
            SellBillGrid.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            SellBillGrid.DefaultCellStyle.ForeColor = alterFontColor;
            SellBillGrid.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            SellBillGrid.DefaultCellStyle.SelectionForeColor = alterHeaderColor;

            ImportBillGrid.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            ImportBillGrid.DefaultCellStyle.ForeColor = alterFontColor;
            ImportBillGrid.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            ImportBillGrid.DefaultCellStyle.SelectionForeColor = alterHeaderColor;
            AssociateAndRaiseViewEvents();
        }
        public string valueSearch
        {
            get => lbDate.Text;
            set => lbDate.Text = value;
        }

        public int status;


        private void AssociateAndRaiseViewEvents()
        {

            //Sự kiện thay đổi dữ liệu trong datagridview
            ImportBillGrid.CellContentClick += (s, e) =>
            {
                int actions = e.ColumnIndex;
                if(actions == 4)
                {
                    int x = int.Parse(ImportBillGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    BillDetail bD = new BillDetail(1, x);
                    bD.Show();
                }                           
            };

            SellBillGrid.CellContentClick += (s, e) =>
            {
                int actions = e.ColumnIndex;
                if (actions == 4)
                {
                    int x = int.Parse(SellBillGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    BillDetail bD = new BillDetail(0, x);
                    bD.Show();
                }
            };

            //Sự kiện đổi trang dữ liệu

            btnPrev.Enabled = false;
            CheckEnable();


            btnPrev.Click += (s, e) =>
            {
                btnNext.Enabled = true;
                if (CurrentPage > 2)
                {
                    CurrentPage--;
                    btnPrev.Enabled = true;
                }
                else
                {
                    CurrentPage--;
                    btnPrev.Enabled = false;
                }
                PageChanged?.Invoke(this, EventArgs.Empty);

            };

            btnNext.Click += (s, e) =>
            {
                btnPrev.Enabled = true;
                if (CurrentPage < TotalPage - 1)
                {
                    btnNext.Enabled = true;
                    CurrentPage += 1;
                }
                else
                {
                    CurrentPage++;
                    btnNext.Enabled = false;
                }
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            btnFirst.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnFirst.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            btnSecond.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnSecond.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };
            btnThird.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnThird.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };
            btnFourth.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnFourth.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            btnFive.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnFive.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            //Su kien thay doi dong
            ddRows.SelectedIndexChanged += (s, e) =>
            {
                PageSize = int.Parse(ddRows.SelectedItem.ToString());
                PageChanged?.Invoke(this, EventArgs.Empty);
            };
        }




        public event EventHandler GetNumberOfStaff;
        public event EventHandler PageChanged;

        public void HandlePagination()
        {
            //MessageBox.Show(TotalPage + " "+ CurrentPage);
            btnSecond.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = true;
            btnFive.Visible = true;
            if (TotalPage <= 1)
            {
                btnSecond.Visible = false;
                btnThird.Visible = false;
                btnFourth.Visible = false;
                btnFive.Visible = false;
            }
            else if (TotalPage == 2)
            {
                btnThird.Visible = false;
                btnFourth.Visible = false;
                btnFive.Visible = false;
            }
            else if (TotalPage == 3)
            {
                btnFourth.Visible = false;
                btnFive.Visible = false;
            }
            else if (TotalPage == 4)
            {
                btnFive.Visible = false;
            }

            //Chuyển số nếu trang quá trang
            ChangePage();

        }
        private void ChangePage()
        {
            int first = int.Parse(btnFirst.Text);
            int second = int.Parse(btnSecond.Text);
            int third = int.Parse(btnThird.Text);
            int fourth = int.Parse(btnFourth.Text);
            int fiveth = int.Parse(btnFive.Text);
            if (TotalPage > 5)
            {
                if (TotalPage - 1 >= fiveth)
                {
                    if (currentPage == fourth || currentPage == fiveth)
                    {
                        btnFirst.Text = (first + 1).ToString();
                        btnSecond.Text = (second + 1).ToString();
                        btnThird.Text = (third + 1).ToString();
                        btnFourth.Text = (fourth + 1).ToString();
                        btnFive.Text = (fiveth + 1).ToString();
                    }
                }
                else if (TotalPage - 2 >= fiveth)
                {
                    if (currentPage == fiveth)
                    {
                        btnFirst.Text = (first + 2).ToString();
                        btnSecond.Text = (second + 2).ToString();
                        btnThird.Text = (third + 2).ToString();
                        btnFourth.Text = (fourth + 2).ToString();
                        btnFive.Text = (fiveth + 2).ToString();
                    }
                }
                else if (first - 1 > 0)
                {
                    if (currentPage == second || currentPage == first)
                    {
                        btnFirst.Text = (first - 1).ToString();
                        btnSecond.Text = (second - 1).ToString();
                        btnThird.Text = (third - 1).ToString();
                        btnFourth.Text = (fourth - 1).ToString();
                        btnFive.Text = (fiveth - 1).ToString();
                    }
                }
                else if (first - 2 > 0)
                {
                    btnFirst.Text = (first - 2).ToString();
                    btnSecond.Text = (second - 2).ToString();
                    btnThird.Text = (third - 2).ToString();
                    btnFourth.Text = (fourth - 2).ToString();
                    btnFive.Text = (fiveth - 2).ToString();
                }


            }
            //MessageBox.Show(currentPage.ToString());
        }
        public void displayImportBill(List<Dictionary<string, object>> ImportList)
        {
            HandleGridView.SetMiddleCenter(5, ImportBillGrid);
            //Ở đây rows 1 trang là 10;
            ImportBillGrid.Rows.Clear();
            Image imageEye = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            foreach (var item in ImportList)
            {
                ImportBillGrid.Rows.Add(
                    new object[]
                    {
                        item["id"].ToString(),
                        item["staff_name"].ToString(),
                        item["supplier_name"].ToString(),
                        item["import_date"].ToString(),
                        imageEye
                    }
                    );
            }
        }

        public void displaySellBill(List<Dictionary<string, object>> SellList)
        {
            HandleGridView.SetMiddleCenter(5, SellBillGrid);
            //Ở đây rows 1 trang là 10;
            SellBillGrid.Rows.Clear();
            Image imageEye = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            foreach (var item in SellList)
            {
                SellBillGrid.Rows.Add(
                    new object[]
                    {
                        item["id"].ToString(),
                        item["staff_name"].ToString(),
                        item["customer_name"].ToString(),
                        item["sell_date"].ToString(),
                        imageEye
                    }
                    );
            }
        }

        public void ChangeLabelOfShowing(string label)
        {
            lbShowing.Text = label;
        }

        public void GetCountOfBill(Dictionary<string, object> numberBill)
        {
            ddRows.Text = "10";
            TotalRows = (int)numberBill["number"];
            TotalPage = (int)Math.Ceiling((double)((int)numberBill["number"]) / PageSize);
        }
        public void isClicked(string search)
        {
            foreach (Control control in pagination.Controls)
            {
                if (control is BunifuButton button)
                {
                    if (button.Text != search)
                    {
                        button.IdleFillColor = Color.Transparent;
                    }
                    else
                    {
                        button.IdleFillColor = Color.FromArgb(105, 181, 255);

                    }

                }
            }

        }
        public void CheckEnable()
        {
            if (CurrentPage < TotalPage)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
            if (CurrentPage > 1)
            {
                btnPrev.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;
            }
        }

        private void BillDataTable_Load(object sender, EventArgs e)
        {
            valueSearch = "";
            GetNumberOfStaff?.Invoke(this, EventArgs.Empty);
            if(status == 1)
            {
                SellBillGrid.Visible = false;

            }
            else
            {
                ImportBillGrid.Visible = false;
            }
        }



        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            valueSearch = dtpStartDate.Value.ToString("yyyy-MM-dd");
            lbDate.Text = valueSearch;
            PageChanged?.Invoke(this, EventArgs.Empty);
        }

        private void lbDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            BillOverall bill = new BillOverall(0);
            bill.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            BillOverall bill = new BillOverall(1);
            bill.Show();
        }
    }
}

