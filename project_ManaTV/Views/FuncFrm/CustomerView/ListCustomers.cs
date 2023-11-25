using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Views.Components;
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
        private List<BunifuButton> lstPageNumberBtn;
        private int pageSize = 10;
        private int pageNumber = 1;
        public ListCustomers()
        {
            _customerPresenter = new CustomerPresenter();
            pageSize = 10;
            InitializeComponent();
            InitForm();
            HandlePagination();
            AddEventPagination();

        }

        private void InitForm()
        {
            this.BackColor = ColorTranslator.FromHtml("#29374B");
            tabList.BackColor = System.Drawing.Color.White;
            tabTrash.BackColor = System.Drawing.Color.White;
            this.Padding = new Padding(0, 10, 0, 0);

            txtSearchCustomer.Height = dpFilterCustomer.Height;
            btnSearchCustomer.Height = dpFilterCustomer.Height;
            btnAddNewCustomer.Height = dpFilterCustomer.Height;

            txtSearchCustomer.Location = new Point(txtSearchCustomer.Location.X, dpFilterCustomer.Location.Y);
            btnSearchCustomer.Location = new Point(btnSearchCustomer.Location.X, dpFilterCustomer.Location.Y);
            btnAddNewCustomer.Location = new Point(btnAddNewCustomer.Location.X, dpFilterCustomer.Location.Y);
        }

        public Size gridView { get => gridCustomer.Size; set => gridCustomer.Size = gridTrashCustomer.Size = value; }
        public Size tab { get => tabList.Size; set => tabList.Size = tabTrash.Size = value; }
        public void ShowTabTrash()
        {
            tabCustomer.SelectedTab = tabTrash;
        }

        private void ListCustomers_Load(object sender, EventArgs e)
        {
            RenderListData(_customerPresenter.GetByPagination(pageNumber, pageSize));
        }

        //CRUD on table
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
                    //ShowToast("ok ddaays", BunifuSnackbar.MessageTypes.Success);
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
                        RenderListData(_customerPresenter.GetByPagination(pageNumber, pageSize));
                        HandlePagination();
                    };
                    formCustomer.Show();
                }
                if (clickedColumn.Name == "actionDelete")
                {
                    var id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    var confirmModal = new ConfirmModal("delete");
                    confirmModal.ConfirmClick += (s, ev) =>
                    {
                        _customerPresenter.SetDeleteStatus(id, true);
                        RenderListData(_customerPresenter.GetByPagination(1, pageSize));
                        HandlePagination();
                    };
                    confirmModal.ShowDialog();
                    //MessageBox.Show("Delete");
                }

            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var formCustomer = new FormCustomer("add", _customerPresenter);
            formCustomer.AfterClick += (s, ev) =>
            {
                RenderListData(_customerPresenter.GetByPagination(1, pageSize));
                HandlePagination();
            };
            formCustomer.Show();
        }

        private void RenderListData(List<Customer> lstCustomer)
        {
            gridCustomer.Rows.Clear();
            Image actionDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            Image actionUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            Image actionRestore = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "restore.png"));
            foreach (var customer in lstCustomer)
            {
                //Show top view
                if (customer.IsDeleted == true) continue;
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

            gridTrashCustomer.Rows.Clear();
            foreach (var customer in _customerPresenter.GetAll())
            {
                //Show top view
                if (customer.IsDeleted == false) continue;
                gridTrashCustomer.Rows.Add(new object[]
                {
                    0,
                    customer.Id,
                    customer.FullName,
                    customer.PhoneNumber,
                    customer.Email,
                    customer.Address,
                    actionDelete,
                    actionRestore
                });
            }



        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            var searchKey = txtSearchCustomer.Text;
            var filterBy = dpFilterCustomer.Text;
            if (filterBy == "" || filterBy == null) return;
            filterBy = filterBy.ToLower();
            filterBy = filterBy.Replace(" ", "");
            searchKey = searchKey.Trim().ToLower();
            var resSearch = _customerPresenter.Search(searchKey, filterBy).Where(x => x.IsDeleted == false).ToList();
            _customerPresenter.ListCustomerRender = resSearch;
            RenderListData(_customerPresenter.GetByPagination(1, pageSize));
            HandlePagination();


        }


        //PAGINATION
        private EventHandler btnPageHandler;
        private EventHandler btnPrevHandler;
        private EventHandler btnNextHandler;
        private void HandlePagination()
        {
            //display buttons
            lstPageNumberBtn = new List<BunifuButton>() { btnFirstPage, btnSecondPage, btnThirdPage };
            ResetPageButtonDefault();
            if (_customerPresenter.TotalPage <= 2) { btnThirdPage.Visible = false; }
            if (_customerPresenter.TotalPage <= 1) { btnSecondPage.Visible = false; }
            pageNumber = 1;
            SetActivePage(1);
            dpPageSize.Text = pageSize.ToString();

        }
        private void AddEventPagination()
        {
            foreach (var btnPageNumber in lstPageNumberBtn)
            {
                btnPageHandler = (s, e) => MoveToPage(int.Parse(btnPageNumber.Text));
                btnPageNumber.Click += btnPageHandler;
            }
            btnPrevHandler = (s, e) => MoveToPage(pageNumber - 1);
            btnNextHandler = (s, e) => MoveToPage(pageNumber + 1);
            btnPrev.Click += btnPrevHandler;
            btnNext.Click += btnNextHandler;

        }
        private void dpPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = int.Parse(dpPageSize.Text);
            var lstCustomer = _customerPresenter.GetByPagination(1, pageSize);
            HandlePagination();
            RenderListData(lstCustomer);
          
        }

        private void SetActivePage(int pageNumber)
        {
            foreach (var btnPageNumber in lstPageNumberBtn)
            {
                if (btnPageNumber.Text == pageNumber.ToString())
                {
                    btnPageNumber.BackColor = System.Drawing.Color.FromArgb(105, 181, 255);
                    //btnPageNumber.ForeColor = Color.White;
                }
                else
                {
                    btnPageNumber.BackColor = System.Drawing.Color.Transparent;
                    //btnPageNumber.ForeColor = Color.FromArgb(40, 96, 144);
                }
            }
        }

        private void ResetPageButtonDefault()
        {
            foreach (var btnPage in lstPageNumberBtn)
            {
                btnPage.Text = btnPage.Tag.ToString();
                btnPage.Visible = true;
            }

        }

        private void MoveToPage(int pageNumber)
        {
            //MessageBox.Show(pageNumber.ToString()+" "+ _customerPresenter.TotalPage);
            if (pageNumber > _customerPresenter.TotalPage || pageNumber < 1) return;
            this.pageNumber = pageNumber;
            var lstCustomer = _customerPresenter.GetByPagination(pageNumber, pageSize);
            RenderListData(lstCustomer);
            if (_customerPresenter.TotalPage > 3 && pageNumber >= 3 && pageNumber < _customerPresenter.TotalPage)
            {
                btnFirstPage.Text = (pageNumber - 1).ToString();
                btnThirdPage.Text = (pageNumber + 1).ToString();
                btnSecondPage.Text = pageNumber.ToString();
            }
            else if (pageNumber < 3)
            {
                btnFirstPage.Text = "1";
                btnSecondPage.Text = "2";
                btnThirdPage.Text = "3";

            }
            SetActivePage(pageNumber);
        }


        //TRASH
        private void gridTrashCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                
                DataGridViewRow selectedRow = gridTrashCustomer.Rows[e.RowIndex];
                DataGridViewColumn clickedColumn = gridTrashCustomer.Columns[e.ColumnIndex];
                selectedRow.Cells[0].Value = (int)selectedRow.Cells[0].Value == 1 ? 0 : 1;

                if (clickedColumn.Name == "actionDeleteTrash")
                {
                    var id = int.Parse(selectedRow.Cells["IDTrash"].Value.ToString());
                    var confirmModal = new ConfirmModal("delete");
                    confirmModal.ConfirmClick += (s, ev) =>
                    {
                        _customerPresenter.Delete(id);
                        RenderListData(_customerPresenter.GetByPagination(pageNumber, pageSize));
                        HandlePagination();
                    };
                    confirmModal.ShowDialog();
                    //MessageBox.Show("Delete");
                }

                if (clickedColumn.Name == "actionRestore")
                {
                    var id = int.Parse(selectedRow.Cells["IDTrash"].Value.ToString());
                    _customerPresenter.SetDeleteStatus(id, false);
                    RenderListData(_customerPresenter.GetByPagination(pageNumber, pageSize));
                    HandlePagination();
                }
               
            }
            if (e.RowIndex == -1)
            {
                var clickedColumn = gridTrashCustomer.Columns[e.ColumnIndex];
                
                if (clickedColumn.Name == "checkAll")
                {
                    bool checkTick = true;
                    foreach (DataGridViewRow row in gridTrashCustomer.Rows)
                    {
                        if((int)row.Cells[0].Value == 0)
                        {
                            checkTick = false;
                        }

                    }
                    var val = 1;
                    clickedColumn.HeaderText = "  ☑";
                    if (checkTick) 
                    { 
                        val = 0;
                        clickedColumn.HeaderText = "   ☐";
                    }
                    foreach (DataGridViewRow row in gridTrashCustomer.Rows)
                    {
                        row.Cells[0].Value = val;
                    }
                }
            }
        }

        private void btnRestoreCustomer_Click(object sender, EventArgs e)
        {
            var listId = new List<int>();
            foreach (DataGridViewRow row in gridTrashCustomer.Rows)
            {
                if ((int)row.Cells[0].Value == 1)
                {
                    listId.Add((int)row.Cells["IDTrash"].Value);
                }
            }
            foreach (var id in listId)
            {
                _customerPresenter.SetDeleteStatus(id, false);
            }
            RenderListData(_customerPresenter.GetByPagination(pageNumber, pageSize));
            HandlePagination();
        }

        private void btnRemoveTrash_Click(object sender, EventArgs e)
        {
            var listId = new List<int>();
            foreach (DataGridViewRow row in gridTrashCustomer.Rows)
            {
                if((int)row.Cells[0].Value == 1)
                {
                    listId.Add((int)row.Cells["IDTrash"].Value);
                }
            }
            if(listId.Count > 0)
            {
                var confirmModal = new ConfirmModal("delete");
                confirmModal.ConfirmClick += (s, ev) =>
                {
                    foreach (var id in listId)
                    {
                        _customerPresenter.Delete(id);
                    }
                    RenderListData(_customerPresenter.GetByPagination(pageNumber, pageSize));
                };
                confirmModal.ShowDialog();
            }
        }

        private void btnSearchTrash_Click(object sender, EventArgs e)
        {
            
            var searchKey = txtSearchTrash.Text;
            var filterBy = dpFilterTrash.Text;
            if (filterBy == "" || filterBy == null) return;
            filterBy = filterBy.ToLower();
            filterBy = filterBy.Replace(" ", "");
            searchKey = searchKey.Trim().ToLower();
            var resSearch = _customerPresenter.Search(searchKey, filterBy).Where(x => x.IsDeleted == true).ToList();

            Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            Image actionRestore = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "restore.png"));
            gridTrashCustomer.Rows.Clear();
            foreach (var customer in resSearch)
            {
                //Show top view
                if (customer.IsDeleted == false) continue;
                gridTrashCustomer.Rows.Add(new object[]
                {
                    0,
                    customer.Id,
                    customer.FullName,
                    customer.PhoneNumber,
                    customer.Email,
                    customer.Address,
                    actionDelete,
                    actionRestore
                });
            }


        }


        //ALL
        public void ShowToast(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            snackBarTab.Show(this, message,
                messageTypes,
                1000,
                "",
                BunifuSnackbar.Positions.TopRight);
        }

        private void tabList_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
