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

namespace project_ManaTV.Views.FuncFrm.ProductView
{
    public partial class FrmTrashListProducts : Form
    {
        private ProductPresenter _objPresenter;
        private List<BunifuButton> _buttonList;
        public Form FRM_LAYOUT { get; set; }
        public FrmTrashListProducts()
        {
            _objPresenter = new ProductPresenter();
            InitializeComponent();
            InitForm();
            _buttonList = new List<BunifuButton>() { btnFirstPage, btnSecondPage, btnThirdPage, btnPrev, btnNext };
            _objPresenter.SetPagination(btnFirstPage, btnSecondPage, btnThirdPage, btnPrev,btnNext, dpPageSize);
            AddEventListenerPagination();
 

        }

        private void InitForm()
        {
            this.BackColor = Color.White;

            txtSearch.Height = dpFilter.Height;
            btnSearch.Height = dpFilter.Height;
            btnRemoveTrash.Height = dpFilter.Height;
            btnRestoreCustomer.Height = dpFilter.Height;

            txtSearch.Location = new Point(txtSearch.Location.X, dpFilter.Location.Y);
            btnSearch.Location = new Point(btnSearch.Location.X, dpFilter.Location.Y);
            btnRestoreCustomer.Location = new Point(btnRestoreCustomer.Location.X, dpFilter.Location.Y);
            btnRemoveTrash.Location = new Point(btnRemoveTrash.Location.X, dpFilter.Location.Y);
        }

        private void TrashListProducts_Load(object sender, EventArgs e)
        {
            RenderListData(_objPresenter.GetListByPagination(true));
        }
        //CRUD on table
        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        _objPresenter.Delete(id);
                        EventAfterSuccess("Deleted Successfully!");
                    };
                    confirmModal.ShowDialog();
                    //MessageBox.Show("Delete");
                }
                if (clickedColumn.Name == "actionRestore")
                {
                    var id = int.Parse(selectedRow.Cells["IDTrash"].Value.ToString());
                    _objPresenter.SetDeleteStatus(id, false);
                    EventAfterSuccess("Data restored Successfully!");
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
                        if ((int)row.Cells[0].Value == 0)
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



        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchKey = txtSearch.Text;
            var filterBy = dpFilter.Text;
            if (filterBy == "" || filterBy == null) return;
            filterBy = filterBy.ToLower();
            filterBy = filterBy.Replace(" ", "");
            searchKey = searchKey.Trim().ToLower();
            var resSearch = _objPresenter.Search(searchKey, filterBy, true).ToList();
            RenderListData(resSearch);
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
                _objPresenter.SetDeleteStatus(id, false);
            }
            EventAfterSuccess("Data restored Successfully!");
        }

        private void btnRemoveTrash_Click(object sender, EventArgs e)
        {
            var listId = new List<int>();
            foreach (DataGridViewRow row in gridTrashCustomer.Rows)
            {
                if ((int)row.Cells[0].Value == 1)
                {
                    listId.Add((int)row.Cells["IDTrash"].Value);
                }
            }
            if (listId.Count > 0)
            {
                var confirmModal = new ConfirmModal("delete");
                confirmModal.ConfirmClick += (s, ev) =>
                {
                    foreach (var id in listId)
                    {
                        _objPresenter.Delete(id);
                    }
                    EventAfterSuccess("Deleted Successfully!");
                };
                confirmModal.ShowDialog();
            }
        }

        //FORM EVENT
        private void RenderListData(List<ProductViewModel> lstobj)
        {
            gridTrashCustomer.Rows.Clear();
            
            Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            Image actionRestore = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "restore.png"));
            foreach (var obj in lstobj)
            {
                gridTrashCustomer.Rows.Add(new object[]
                {
                    0,
                    obj.Id,
                    obj.ManufacturerName +" "+obj.DesignName +" "+obj.ScreenName,
                    obj.ColorName,
                    obj.SizeName,
                    obj.CountryName,
                    obj.ProductAmount,
                    obj.ProductImportMoney,
                    actionDelete,
                    actionRestore
                });
            }

        }

        private void AddEventListenerPagination()
        {
            foreach (var btnPageNumber in _buttonList)
            {
                btnPageNumber.Click += (s, e) =>RenderListData(_objPresenter.GetListByPagination(true));
            }
            dpPageSize.SelectedIndexChanged += (s, e) => RenderListData(_objPresenter.GetListByPagination(true));

        }


        //Notifications
        public void ShowToast(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            //BunifuSnackbar snackbar = new BunifuSnackbar();
            //snackbar.Host = BunifuSnackbar.Hosts.Control;
            snackBarTab.Show(FRM_LAYOUT, message,
                messageTypes,
                1000,
                "",
                BunifuSnackbar.Positions.TopRight);
        }

        private void EventAfterSuccess(string message)
        {
            txtSearch.Text = "";
            dpFilter.Text = "";
            _objPresenter.ResetPagination();
            RenderListData(_objPresenter.GetListByPagination(true));
            ShowToast(message, BunifuSnackbar.MessageTypes.Success);
        }

        
    }
}
