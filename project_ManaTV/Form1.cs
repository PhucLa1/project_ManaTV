using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool productExpand = false;
        private void productTrans_Tick(object sender, EventArgs e)
        {
            if (productExpand == false)
            {
                productSideBar.Height += 10;
                if (productSideBar.Height >= 305)
                {
                    productExpand = true;
                    productTrans.Stop();
                }
            }
            else
            {
                productSideBar.Height -= 10;
                if (productSideBar.Height <= 60)
                {
                    productExpand = false;
                    productTrans.Stop();
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            

        }

        private void startFormLoad()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = "select * from Colors where id = @id";
            db.SetQuery(sql);
            var data = db.LoadRow(1);
            MessageBox.Show(data["names"] + " ");


            //string sql = "select * from Colors";
            //db.SetQuery(sql);
            //var data = db.LoadAllRows();
            //int i = 1;
            //foreach (var row in data)
            //{
            //    MessageBox.Show(row["names"]+" ");
            //}


            //dataGridView1.Columns.Add("FirstName", "First Name");
            //dataGridView1.Columns.Add("LastName", "Last Name");
            //dataGridView1.Columns.Add("Age", "Age");
            //Database db = new Database();
            //// Gọi phương thức SetQuery để thiết lập câu truy vấn
            //db.SetQuery("SELECT * FROM Colors");

            //// Gọi phương thức ExecuteReader để thực hiện truy vấn
            //SqlDataReader reader = db.Excute();

            //// Tạo DataTable để chứa dữ liệu
            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);

            //// Hiển thị dữ liệu lên DataGridView
            //dataGridView1.DataSource = dataTable;

            //// Đóng kết nối và giải phóng tài nguyên
            //db.Disconnect();
            //Database db = new Database();
            //string query = "update Colors set names = @value where id = @condition";
            //db.SetQuery(query);

            //object value = "phucdepzaii";
            //int condition = 1;

            //object[] myArray = new object[]
            //{
            //    "phucdepzao", 1
            //};

            //SqlDataReader reader = db.Excute(myArray);
        }

        private bool staffExpand = false;
        private void staffTrans_Tick(object sender, EventArgs e)
        {
            if (staffExpand == false)
            {
                staffSideBar.Height += 10;
                if (staffSideBar.Height >= 305)
                {
                    staffExpand = true;
                    staffTrans.Stop();
                }
            }
            else
            {
                staffSideBar.Height -= 10;
                if (staffSideBar.Height <= 60)
                {
                    staffExpand = false;
                    staffTrans.Stop();
                }
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            staffTrans.Start();
        }

        private void searchFunction_TextChanged(object sender, EventArgs e)
        {
            Dictionary<Control, string> buttonValues = GetButtonValuesFromPanels(sidebar);
            string text = searchFunction.Text.ToLower();
            foreach (KeyValuePair<Control, string> kvp in buttonValues)
            {
                if (!kvp.Value.Contains(text))
                {
                    kvp.Key.Visible = false;
                }
                else
                {
                    kvp.Key.Visible = true;
                }
            }
        }
        private Dictionary<Control, string> GetButtonValuesFromPanels(FlowLayoutPanel panel)
        {
            Dictionary<Control, string> buttonValues = new Dictionary<Control, string>();
            foreach (Control control in panel.Controls)
            {
                if (control is FlowLayoutPanel subPanel)
                {

                    foreach (Control subControl in subPanel.Controls)
                    {

                        if (subControl is BunifuButton button)
                        {
                            buttonValues.Add(button, button.Text.ToLower());
                        }
                    }
                }
                else if (control is BunifuButton button)
                {
                    buttonValues.Add(button, button.Text.ToLower());
                }
            }

            return buttonValues;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();

        }

        private bool sidebarExpand = true;
        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 266)
                {
                    sidebarExpand = true;
                    sidebarTrans.Stop();
                    setButtonWidth();

                }
            }
            else
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 59)
                {
                    sidebarExpand = false;
                    sidebarTrans.Stop();
                    setButtonWidth();
                }
            }
        }

        private void setButtonWidth()
        {
            btnLogOut.Width = sidebar.Width;
            btnStaff.Width = sidebar.Width;
            btnProduct.Width = sidebar.Width;
            btnDashboard.Width = sidebar.Width; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("234");
        }
    }
}
