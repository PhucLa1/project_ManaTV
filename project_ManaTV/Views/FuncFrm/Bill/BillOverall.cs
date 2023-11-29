using Bunifu.UI.WinForms;
using project_ManaTV.Repository;
using project_ManaTV.Views.Components;
using project_ManaTV.Views.FuncFrm.CustomerView;
using project_ManaTV.Views.FuncFrm.ProductView.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace project_ManaTV.Views.FuncFrm.Bill
{
    public partial class BillOverall : Form
    {
        //0 : Sale Bill, 1 : Import Bill
        public Form FRM_LAYOUT { get; set; }//thêm FRM_Layout
        private string screen, design, color;
        private float size;
        private int totalMoney = 0;
        private int staffID;
        private int supplierID;
        private int customerID;
        public Dictionary<int, Product> products = new Dictionary<int, Product>();
        private BillRepository bR = new BillRepository();
        private int status;
        public BillOverall(int _status)
        {
            status = _status;
            InitializeComponent();
            ProductDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 96, 144);
            ProductDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            ProductDGV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            ProductDGV.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void BillOverall_Load(object sender, EventArgs e)
        {

            //Init variable
            InitVariable();

            //Init Datagridview 
            //4 đối số để filter : screen,size,desgin,color
            InitDataGridView();

            //Init for dropdown
            InitScreen();
            InitSize();
            InitColor();
            InitDesigns();
            InitStaff();
            InitSupplier();
            //Total Money
            lbTotal.Text = "0";

            //Nếu là hóa đơn bán 
            if (status == 0)
            {
                lbCustomer.Text = "Choose customer";
                lbSupplier.Visible = false;
                lbSupplier.Dispose();
                SupplierDD.Visible = false;
                btnImportOrSale.Text = "Sell";
                lbBill.Text = $"Sell Bill";
            }
            //Import Bill
            else
            {
                btnAddCustomer.Visible = false;
                lbCustomer.Visible = false;
                btnImportOrSale.Text = "Import";
                lbBill.Text = $"Import Bill";
            }
        }

        private void InitSupplier()
        {
            List<string> supplierDD = bR.GetAllSupplier();
            foreach (var supplier in supplierDD)
            {
                SupplierDD.Items.Add(supplier);
            }
        }

        private void InitStaff()
        {
            List<string> staffDD = bR.GetAllStaff();
            foreach (var staff in staffDD)
            {
                StaffDD.Items.Add(staff);
            }
        }

        private void InitDataGridView()
        {
            ProductDGV.Rows.Clear();
            var result = bR.GetFilterProduct(screen, size, design, color);
            foreach (var item in result)
            {
                ProductDGV.Rows.Add(new object[]
                {
                    item["id"].ToString(),
                    $"Tivi {item["manufacturer_name"].ToString()} " +
                    $"{item["screen_name"].ToString()} " +
                    $"{item["screen_size"].ToString()} " +
                    $"{item["design_name"].ToString()}"
                });
            }
        }

        private void InitVariable()
        {
            screen = ""; size = -1; design = ""; color = "";
        }

        private void InitDesigns()
        {
            List<string> designsDD = bR.GetAllDesign();
            foreach (var design in designsDD)
            {
                DesignDD.Items.Add(design);
            }
        }

        private void InitColor()
        {
            List<string> colorsDD = bR.GetAllColor();
            foreach (var color in colorsDD)
            {
                ColorDD.Items.Add(color);
            }
        }

        private void InitSize()
        {
            List<string> sizeDD = bR.GetAllSize();
            foreach (var size in sizeDD)
            {
                SizeDD.Items.Add(size);
            }
        }

        private void InitScreen()
        {
            List<string> screenDD = bR.GetAllScreen();
            foreach (var screen in screenDD)
            {
                ScreenDD.Items.Add(screen);
            }
        }

        private void screenDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            screen = ScreenDD.Text;
            InitDataGridView();
        }

        private void DesignDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            design = DesignDD.Text;
            InitDataGridView();
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = int.Parse(ProductDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            Product productControl = new Product(x);
            //Thêm vào trong danh sách
            if (products.ContainsKey(x))
            {
                products[x].numberProduct++;
            }
            else
            {
                products.Add(x, productControl);
                productFLP.Controls.Add(productControl);
            }
            setTotalMoney();
            productControl.DataChanged += (s, ev) =>
            {
                setTotalMoney();
            };
            productControl.DisposeChange += (s, ev) =>
            {
                products.Remove(productControl.i);
                setTotalMoney();
                productControl.Dispose();
            };




            //Chỉnh scroll bar
            int totalWidth = productFLP.Controls.Count * productControl.Height;
            // Thay YourUserControlWidth bằng chiều rộng của UserControl
            if (totalWidth - productFLP.ClientSize.Height > scrollBarHeight.Minimum)
            {
                scrollBarHeight.Maximum = totalWidth - productFLP.ClientSize.Height + 50;
            }

        }


        private void setTotalMoney()
        {
            ICollection<int> keys = products.Keys;
            totalMoney = 0;
            foreach (int key in keys)
            {
                //MessageBox.Show(key.ToString());
                totalMoney += products[key].numberProduct * products[key].priceProduct;

            }
            lbTotal.Text = totalMoney.ToString();
        }
        private void ShowMessage(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            Message.Show(this, message, messageTypes, 1000, "", BunifuSnackbar.Positions.TopRight);
        }

        private void btnImportOrSale_Click(object sender, EventArgs e)
        {
            ICollection<int> keys = products.Keys;
            if (status == 1) //Là nhập hàng
            {

                if (StaffDD.SelectedItem != null && SupplierDD.SelectedItem != null && keys.Count != 0)
                {

                    //Các dữ liệu 
                    staffID = int.Parse(StaffDD.Text.Substring(StaffDD.Text.IndexOf(':') + 1).Trim());
                    supplierID = int.Parse(SupplierDD.Text.Substring(SupplierDD.Text.IndexOf(':') + 1).Trim());

                    //Insert vào db
                    bR.InsertToImportBill(supplierID, staffID);


                    foreach (int key in keys)
                    {
                        bR.InsertToImportBillDetail
                            (products[key].i, products[key].numberProduct, products[key].priceProduct);
                        bR.ChangePriceProduct(products[key].priceProduct, products[key].i);
                    }

                    //Xóa hết các thông tin ở đó đii
                    products.Clear();
                    productFLP.Controls.Clear();
                    setTotalMoney();

                    //Hiện thông báo
                    ShowMessage($"You have successfully imported goods on the day {DateTime.UtcNow.AddHours(7)}", BunifuSnackbar.MessageTypes.Success);
                    this.Close();
                }
                else
                {
                    if (StaffDD.SelectedItem == null)
                    {
                        ShowMessage("Employees have not been selected yet", BunifuSnackbar.MessageTypes.Error);
                    }
                    if (SupplierDD.SelectedItem == null)
                    {
                        ShowMessage("Supplier have not been selected yet", BunifuSnackbar.MessageTypes.Error);
                    }
                }
            }
            else //Sale Bill
            {
                if (StaffDD.SelectedItem != null && lbCustomer.Text != "Choose customer")
                {
                    staffID = int.Parse(StaffDD.Text.Substring(StaffDD.Text.IndexOf(':') + 1).Trim());

                    //Insert vào db
                    bR.InsertIntoSellBill(customerID, staffID);
                    foreach (int key in keys)
                    {
                        bR.InsertIntoSellBillDetail
                            (products[key].i, products[key].numberProduct, products[key].priceProduct);
                    }

                    //Xóa hết các thông tin ở đó đii
                    products.Clear();
                    productFLP.Controls.Clear();
                    setTotalMoney();

                    //Hiện thông báo
                    ShowMessage($"You have successfully sell goods on the day {DateTime.UtcNow.AddHours(7)}", BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    if (StaffDD.SelectedItem == null)
                    {
                        ShowMessage("Employees have not been selected yet", BunifuSnackbar.MessageTypes.Error);
                    }
                    if (lbCustomer.Text == "Choose customer")
                    {
                        ShowMessage("Customers have not been selected yet", BunifuSnackbar.MessageTypes.Error);
                    }
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("1");
            ListCustomers listCustomers = new ListCustomers();

            listCustomers.OpenToChoose += (s, ev) =>
            {
                lbCustomer.Text = listCustomers.customerName;
                customerID = listCustomers.IDCus;
                listCustomers.Dispose();
            };
            listCustomers.ShowDialog();
        }

        private void btnScanBarcode_Click(object sender, EventArgs e)
        {
            CameraScanner scanner = new CameraScanner();
            scanner.BarcodeScanned += Form_BarcodeScanned;
            scanner.Show();
        }
        private void Form_BarcodeScanned(object sender, string barcodeText)
        {
            int x = int.Parse(barcodeText.Substring(2));
            Product productControl = new Product(x);
            //Thêm vào trong danh sách
            if (products.ContainsKey(x))
            {
                products[x].numberProduct++;
            }
            else
            {
                products.Add(x, productControl);
                productFLP.Controls.Add(productControl);
            }
            setTotalMoney();
            productControl.DataChanged += (s, ev) =>
            {
                setTotalMoney();
            };
            productControl.DisposeChange += (s, ev) =>
            {
                products.Remove(productControl.i);
                setTotalMoney();
                productControl.Dispose();
            };

        }
        private void SizeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = float.Parse(SizeDD.Text);
            InitDataGridView();
        }

        private void ColorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = ColorDD.Text;
            InitDataGridView();
        }
    }
}
