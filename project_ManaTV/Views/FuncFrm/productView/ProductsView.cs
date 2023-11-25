using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Presenters.Colors;
using project_ManaTV.Presenters.Designs;
using project_ManaTV.Repository;
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
        private DesignPresenter _designPresenter;
        private List<BunifuButton> lstPageNumberBtn;
        private int pageSize = 10;
        private int pageNumber = 1;
        public event EventHandler AfterClick;
        public ProductsView()
        {
            _colorPresenter = new ColorPresenter();
            _designPresenter = new DesignPresenter();
            pageSize = 10;
            InitializeComponent();
            InitForm();
            HandlePagination();
            AddEventPagination();
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
        //Pagination
        private EventHandler btnPageHandler;
        private EventHandler btnPrevHandler;
        private EventHandler btnNextHandler;
        private void MoveToPage(int pageNumber)
        {
            //MessageBox.Show(pageNumber.ToString()+" "+ _customerPresenter.TotalPage);
            if (pageNumber > _colorPresenter.TotalPage || pageNumber < 1) return;
            this.pageNumber = pageNumber;
            var lstCustomer = _colorPresenter.GetByPagination(pageNumber, pageSize);
            RenderListData(lstCustomer);
            if (_colorPresenter.TotalPage > 3 && pageNumber >= 3 && pageNumber < _colorPresenter.TotalPage)
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
        public Size gridView { get => gridProduct.Size; set => gridProduct.Size = gridColorProduct.Size = gridDesignProduct.Size = value; }
        public Size tab { get => tabList.Size; set => tabList.Size = tabColor.Size = tabDesign.Size = value; }
        public void ShowTabColor()
        {
            tabProduct.SelectedTab = tabColor;
        }
        public void ShowTabDesign()
        {
            tabProduct.SelectedTab = tabDesign;
        }

        private void tabList_Click(object sender, EventArgs e)
        {
            
        }

        private void gridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RenderListData(List<Models.Color> lstColor)
        {
            gridProduct.Rows.Clear();
            //Image actionDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            //Image actionUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            //Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            //Image actionRestore = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "restore.png"));
            Image actionColorDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            Image actionColorUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            Image actionColorDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            
            gridColorProduct.Rows.Clear();
            foreach (var color in lstColor)
            {
                //Show top view
                gridColorProduct.Rows.Add(new object[]
                {
                    0,
                    color.Id,
                    color.Name,
                    color.Value,
                    color.Status,
                    actionColorDetails,
                    actionColorUpdate,
                    actionColorDelete
                });
            }
            gridDesignProduct.Rows.Clear();
            foreach (var design in _designPresenter.GetByPagination(pageNumber,pageSize))
            {
                //Show top view
                gridDesignProduct.Rows.Add(new object[]
                {
                    0,
                    design.Id,
                    design.Name,
                    design.Status,
                    actionColorDetails,
                    actionColorUpdate,
                    actionColorDelete
                });
            }

        }
        private void ProductsView_Load(object sender, EventArgs e)
        {
            RenderListData(_colorPresenter.GetByPagination(pageNumber, pageSize));
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
            dpColorPage.Text = pageSize.ToString();
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
                RenderListData(_colorPresenter.GetByPagination(1, pageSize));
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
                selectedRow.Cells[0].Value = (int)selectedRow.Cells[0].Value == 1 ? 0 : 1;
                if (clickedColumn.Name == "actionColorDetails")
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
                        RenderListData(_colorPresenter.GetByPagination(1, pageSize)); ;
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
                        RenderListData(_colorPresenter.GetByPagination(1, pageSize)); ;
                        HandlePagination();
                    };
                    confirmModel.ShowDialog();
                }
            }
        }

        private void gridColorProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoveColor_Click(object sender, EventArgs e)
        {
            var listId = new List<int>();
            foreach (DataGridViewRow row in gridColorProduct.Rows)
            {
                if ((int)row.Cells[0].Value == 1)
                {
                    listId.Add((int)row.Cells["IdColor"].Value);
                }
            }
            if (listId.Count() > 0)
            {
                var confirmModel = new ConfirmModal("delete");
                confirmModel.ConfirmClick += (s, ev) =>
                {
                    foreach (var id in listId)
                    {
                        _colorPresenter.Delete(id);
                    }
                    RenderListData(_colorPresenter.GetByPagination(1, pageSize)); ;
                };
                confirmModel.ShowDialog();
            }
        }
        
        private void btnSearchColor_Click(object sender, EventArgs e)
        {
            string searchKey = txtSearchColor.Text;
            string filter = dpFilterColor.Text;
            
            if (filter == "" || filter == null)
            {
                RenderListData(_colorPresenter.GetByPagination(1, pageSize)); ;
            }
            else
            {
                filter = filter.ToLower();
                filter = filter.Replace(" ", "");
                searchKey = searchKey.Trim().ToLower();
                var resSearch = _colorPresenter.Search(searchKey, filter).ToList();
                _colorPresenter.ListColorRender = resSearch;
                Image actionColorDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
                Image actionColorUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
                Image actionColorDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
                gridColorProduct.Rows.Clear();
                foreach (var color in resSearch)
                {
                    //Show top view
                    gridColorProduct.Rows.Add(new object[]
                    {
                    0,
                    color.Id,
                    color.Name,
                    color.Value,
                    color.Status,
                    actionColorDetails,
                    actionColorUpdate,
                    actionColorDelete
                    });
                }
                HandlePagination();
            }
            
        }

        private void dpColorPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = int.Parse(dpColorPage.Text);
            var lstColor = _colorPresenter.GetByPagination(1, pageSize);
            HandlePagination();
            RenderListData(lstColor);
        }

        private void tabProduct_Click(object sender, EventArgs e)
        {

        }

        private void dpDesignPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = int.Parse(dpDesignPage.Text);
            var lstColor = _colorPresenter.GetByPagination(1, pageSize);
            HandlePagination();
            RenderListData(lstColor);
        }

        private void gridDesignProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridDesignProduct.Rows[e.RowIndex];
                DataGridViewColumn clickedColumn = gridDesignProduct.Columns[e.ColumnIndex];
                selectedRow.Cells[0].Value = (int)selectedRow.Cells[0].Value == 1 ? 0 : 1;
                if (clickedColumn.Name == "actionDesignDetails")
                {
                    var id = int.Parse(selectedRow.Cells["IdDesign"].Value.ToString());
                    var selectedDesign = _designPresenter.GetById(id);
                    var GetForm = new ProductForm("details");
                    GetForm.setData(selectedDesign);
                    GetForm.Show();
                }
                if (clickedColumn.Name == "actionDesignRemove")
                {
                    var id = int.Parse(selectedRow.Cells["IdDesign"].Value.ToString());
                    var selectedDesign = _designPresenter.GetById(id);
                    var confirmModel = new ConfirmModal("delete");
                    confirmModel.ConfirmClick += (s, ev) =>
                    {
                        _designPresenter.DeleteById(selectedDesign);
                        RenderListData(_colorPresenter.GetByPagination(1, pageSize)); ;
                        HandlePagination();
                    };
                    confirmModel.ShowDialog();
                }
            }
        }
    }
}
