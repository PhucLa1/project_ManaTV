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
using ScreenSize = project_ManaTV.Models.ScreenSize;

namespace project_ManaTV.Views.FuncFrm.ScreenSizeView
{
    public partial class FrmListScreenSizes : Form
    {
        private ScreenSizePresenter _objPresenter;
        private List<BunifuButton> _buttonList;
        public Form FRM_LAYOUT { get; set; }
        public FrmListScreenSizes()
        {
            _objPresenter = new ScreenSizePresenter();
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
            btnAddNew.Height = dpFilter.Height;

            txtSearch.Location = new Point(txtSearch.Location.X, dpFilter.Location.Y);
            btnSearch.Location = new Point(btnSearch.Location.X, dpFilter.Location.Y);
            btnAddNew.Location = new Point(btnAddNew.Location.X, dpFilter.Location.Y);
        }

        private void ListScreenSizes_Load(object sender, EventArgs e)
        {
            RenderListData(_objPresenter.GetListByPagination());
        }
        //CRUD on table
        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = gridData.Rows[e.RowIndex];
                DataGridViewColumn clickedColumn = gridData.Columns[e.ColumnIndex];

                if (clickedColumn.Name == "actionDetails")
                {
                    var id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    var selectedObj = _objPresenter.GetById(id);
                    var formObj = new FormScreenSize("details");
                    formObj.SetData(selectedObj);
                    formObj.Show();
                }
                if (clickedColumn.Name == "actionUpdate")
                {
                    var id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    var selectedObj = _objPresenter.GetById(id);
                    var formObj = new FormScreenSize("update", _objPresenter);
                    formObj.SetData(selectedObj);
                    formObj.AfterClick += (s, ev) => EventAfterSuccess("Updated Successfully!");
                    formObj.Show();
                }
                if (clickedColumn.Name == "actionDelete")
                {
                    var id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    var confirmModal = new ConfirmModal("delete");
                    confirmModal.ConfirmClick += (s, ev) =>
                    {
                        try
                        {
                            _objPresenter.Delete(id);
                            EventAfterSuccess("Deleted successfully!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Delete failed!");
                            throw;
                        }
                        
                    };
                    confirmModal.ShowDialog();
                }

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var formobj = new FormScreenSize("add", _objPresenter);
            formobj.AfterClick += (s, ev) => EventAfterSuccess("Added successfully!");
            formobj.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchKey = txtSearch.Text;
            var filterBy = dpFilter.Text;
            if (filterBy == "" || filterBy == null) return;
            filterBy = filterBy.ToLower();
            filterBy = filterBy.Replace(" ", "");
            searchKey = searchKey.Trim().ToLower();
            var resSearch = _objPresenter.Search(searchKey, filterBy).ToList();
            RenderListData(resSearch);
        }

        //FORM EVENT
        private void RenderListData(List<ScreenSize> lstobj)
        {
            gridData.Rows.Clear();
            Image actionDetails = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "details.png"));
            Image actionUpdate = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "edit.png"));
            Image actionDelete = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "delete.png"));
            Image actionRestore = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "restore.png"));
            foreach (var obj in lstobj)
            {
                gridData.Rows.Add(new object[]
                {
                    obj.Id,
                    obj.Screen_size,
                    actionDetails,
                    actionUpdate,
                    actionDelete
                });
            }

        }

        private void AddEventListenerPagination()
        {
            foreach (var btnPageNumber in _buttonList)
            {
                btnPageNumber.Click += (s, e) =>RenderListData(_objPresenter.GetListByPagination());
            }
            dpPageSize.SelectedIndexChanged += (s, e) => RenderListData(_objPresenter.GetListByPagination());

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
            RenderListData(_objPresenter.GetListByPagination());
            ShowToast(message, BunifuSnackbar.MessageTypes.Success);
        }

        
    }
}
