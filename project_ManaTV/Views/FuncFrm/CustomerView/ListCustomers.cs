using project_ManaTV.HelpMethod;
using project_ManaTV.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.CustomerView
{
    public partial class ListCustomers : Form
    {
        private CustomerPresenter _customerPresenter;
        public ListCustomers()
        {
            _customerPresenter = new CustomerPresenter();
            InitializeComponent();
        }

        public Size gridView { set => gridCustomer.Size = value; }
        public Size tab { get => tabList.Size; set => tabList.Size = value; }

        private void ListCustomers_Load(object sender, EventArgs e)
        {
            RenderListData();
        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = gridCustomer.Rows[e.RowIndex];
                DataGridViewColumn clickedColumn = gridCustomer.Columns[e.ColumnIndex];

                if (clickedColumn.Name == "actionDetails")
                {
                    var id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    var selectedCustomer = _customerPresenter.GetById(id);
                    var formCustomer = new FormCustomer("details");
                    formCustomer.SetData(selectedCustomer);
                    
                    formCustomer.Show();
                    //MessageBox.Show("Details: "+ id);
                }
                if (clickedColumn.Name == "actionUpdate")
                {
                    var id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    var selectedCustomer = _customerPresenter.GetById(id);
                    var formCustomer = new FormCustomer("update", _customerPresenter);
                    formCustomer.SetData(selectedCustomer);
                    formCustomer.AfterClick += (s, ev) =>
                    {
                        RenderListData();
                    };
                    formCustomer.Show();
                }
                if (clickedColumn.Name == "actionDelete")
                {
                    MessageBox.Show("Delete");
                }

            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var formCustomer = new FormCustomer("add", _customerPresenter);
            formCustomer.AfterClick += (s, ev) =>
            {
                RenderListData();
            };
            formCustomer.Show();
        }

        private void RenderListData()
        {
            gridCustomer.Rows.Clear();
            Image actionDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            Image actionUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            foreach (var customer in _customerPresenter.GetAll())
            {
                gridCustomer.Rows.Add(new object[]
                {
                    customer.Id,
                    customer.FullName,
                    customer.PhoneNumber,
                    customer.Email,
                    customer.Address,
                    actionDetails,
                    actionUpdate,
                    actionDelete
                });
            }
        }
    }
}
