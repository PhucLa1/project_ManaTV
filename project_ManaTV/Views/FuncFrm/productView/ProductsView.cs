using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Presenters.Colors;
using project_ManaTV.Views.Components;
using project_ManaTV.Views.FuncFrm.CustomerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Size = System.Drawing.Size;

namespace project_ManaTV.Views.FuncFrm.productView
{
    public partial class ProductsView : Form
    {
        private ColorPresenter _colorPresenter;
        private List<BunifuButton> lstPageNumberBtn;
        private int pageSize = 10;
        private int pageNumber = 1;
        public event EventHandler AfterClick;
        public ProductsView()
        {
            _colorPresenter = new ColorPresenter();
            pageSize = 10;
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            this.BackColor = ColorTranslator.FromHtml("#29374B");
            tabList.BackColor = Color.White;
            tabColor.BackColor = Color.White;
            this.Padding = new Padding(0, 10, 0, 0);

            txtSearchProduct.Height = dpFilterProduct.Height;
            btnSearchProduct.Height = dpFilterProduct.Height;
            btnAddNewProduct.Height = dpFilterProduct.Height;

            txtSearchProduct.Location = new Point(txtSearchProduct.Location.X, dpFilterProduct.Location.Y);
            btnSearchProduct.Location = new Point(btnSearchProduct.Location.X, dpFilterProduct.Location.Y);
            btnAddNewProduct.Location = new Point(btnAddNewProduct.Location.X, dpFilterProduct.Location.Y);
        }
        public Size gridView { get => gridProduct.Size; set => gridProduct.Size = gridColorProduct.Size = value; }
        public Size tab { get => tabList.Size; set => tabList.Size = tabColor.Size = value; }
        public void ShowTabColor()
        {
            tabProduct.SelectedTab = tabColor;
        }

        private void tabList_Click(object sender, EventArgs e)
        {
            
        }

        private void gridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RenderListData()
        {
            gridProduct.Rows.Clear();
            //Image actionDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            //Image actionUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            //Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            Image actionRestore = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "restore.png"));
            Image actionColorDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            Image actionColorUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            Image actionColorDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            //foreach (var customer in lstCustomer)
            //{
            //Show top view
            //if (customer.IsDeleted == true) continue;
            //gridProduct.Rows.Add(new object[]
            //{
            //    customer.Id,
            //    customer.FullName,
            //    customer.PhoneNumber,
            //  customer.Email,
            //    customer.Address,
            //    actionDetails,
            //    actionUpdate,
            //    actionDelete
            //});
            //}

            gridColorProduct.Rows.Clear();
            foreach (var color in _colorPresenter.GetAll())
            {
                //Show top view
                gridColorProduct.Rows.Add(new object[]
                {
                    color.Id,
                    color.Name,
                    color.Value,
                    color.Status,
                    actionColorDetails,
                    actionColorUpdate,
                    actionColorDelete
                });
            }
        }
        private void ProductsView_Load(object sender, EventArgs e)
        {
            RenderListData();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            
        }
        private void ResetPageButtonDefault()
        {
            foreach (var btnPage in lstPageNumberBtn)
            {
                btnPage.Text = btnPage.Tag.ToString();
                btnPage.Visible = true;
            }

        }
        private void HandlePagination()
        {
            //display buttons
            lstPageNumberBtn = new List<BunifuButton>() { btnFirstPage, btnSecondPage, btnThirdPage };
            ResetPageButtonDefault();
            if (_colorPresenter.TotalPage <= 2) { btnThirdPage.Visible = false; }
            if (_colorPresenter.TotalPage <= 1) { btnSecondPage.Visible = false; }
            pageNumber = 1;
            SetActivePage(1);
            dpPageSize.Text = pageSize.ToString();

        }
        private void SetActivePage(int pageNumber)
        {
            foreach (var btnPageNumber in lstPageNumberBtn)
            {
                if (btnPageNumber.Text == pageNumber.ToString())
                {
                    btnPageNumber.BackColor = Color.FromArgb(105, 181, 255);
                    //btnPageNumber.ForeColor = Color.White;
                }
                else
                {
                    btnPageNumber.BackColor = Color.Transparent;
                    //btnPageNumber.ForeColor = Color.FromArgb(40, 96, 144);
                }
            }
        }
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            var formProduct = new ProductForm("add", _colorPresenter);
            formProduct.AfterClick += (s, ev) =>
            {
                RenderListData();
                HandlePagination();
            };
            formProduct.Show();
        }

        private void gridColorProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridColorProduct.Rows[e.RowIndex];
                DataGridViewColumn clickedColumn = gridColorProduct.Columns[e.ColumnIndex];
                if(clickedColumn.Name == "actionColorDetails")
                {
                    var id = int.Parse(selectedRow.Cells["IdColor"].Value.ToString());
                    var selectedColor = _colorPresenter.GetById(id);
                    var GetForm = new ProductForm("details");
                    GetForm.setData(selectedColor);
                    GetForm.Show();
                }
                if (clickedColumn.Name == "actionColorUpdate")
                {
                    var id = int.Parse(selectedRow.Cells["IdColor"].Value.ToString());
                    var selectedColor = _colorPresenter.GetById(id);
                    var GetForm = new ProductForm("update", _colorPresenter);
                    GetForm.setData(selectedColor);
                    GetForm.AfterClick += (s, ev) =>
                    {
                        RenderListData();
                        HandlePagination();
                    };
                    GetForm.Show();
                }
                if(clickedColumn.Name == "actionColorRemove")
                {
                    var id = int.Parse(selectedRow.Cells["IdColor"].Value.ToString());
                    var selectedColor = _colorPresenter.GetById(id);
                    var confirmModel = new ConfirmModal("delete");
                    confirmModel.ConfirmClick += (s, ev) =>
                    {
                        _colorPresenter.DeleteById(selectedColor);
                        RenderListData();
                        HandlePagination();
                    };
                    confirmModel.ShowDialog();
                }
            }
        }

        private void gridColorProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
