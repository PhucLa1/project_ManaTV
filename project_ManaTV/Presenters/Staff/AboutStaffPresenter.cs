using Bunifu.UI.WinForms;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Presenters.Staff
{
    internal class AboutStaffPresenter
    {
        private readonly m_Staff model;
        private readonly IAboutStaff view;

        public AboutStaffPresenter(m_Staff model, IAboutStaff view)
        {
            this.view = view;
            this.model = model;


            AssociationLoadEvent();
        }

        private void AssociationLoadEvent()
        {
            this.view.AddData += OnAddData;
            this.view.LoadWorkData += OnLoadWorkData;
            this.view.LoadDataById += OnLoadDataById;
            this.view.UpdateData += OnUpdateData;
            this.view.DeleteData += OnDeleteData;
        }

        private void OnDeleteData(object sender, EventArgs e)
        {
            model.SoftDeleteStaff(view.id);
            InitClasses.staffView.ShowMessageOfDel("Delete Success", BunifuSnackbar.MessageTypes.Success);
            InitClasses.DeleteStaff.Dispose();
            OnPageChangedWhenChangeData();
        }

        private void OnUpdateData(object sender, EventArgs e)
        {
            if (this.view.Valiadate() == false)
            {
                this.view.ShowMessage("Error Input", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                //Lưu ảnh vào folder
                string genName = HandleImage.SaveImage("Users");
                this.model.UpdateStaff(this.view.name,
                    this.view.gender, this.view.phoneNumber, this.view.dob, this.view.address, this.view.email,
                    this.view.id_Work, genName, this.view.id
                    );
                this.view.ShowMessage("Update Success", BunifuSnackbar.MessageTypes.Success);
            }
            OnPageChangedWhenChangeData();
        }

        private void OnLoadDataById(object sender, EventArgs e)
        {
            var data = model.getStaffById(view.id);
            this.view.ShowInformation(data);

        }

        private void OnLoadWorkData(object sender, EventArgs e)
        {
            m_Work work = new m_Work();
            var data = work.getAllWork();
            this.view.AddWorkInDropDown(data);
        }

        private void OnAddData(object sender, EventArgs e)
        {
            if (this.view.Valiadate() == false)
            {
                this.view.ShowMessage("Information input failed", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                //Add ảnh vào thư mục trước
                string genName = HandleImage.SaveImage("Users");
                this.model.AddNewStaff(this.view.name,
                    this.view.gender, this.view.phoneNumber, this.view.dob, this.view.address, this.view.email,
                    this.view.id_Work, genName
                    );
                this.view.ShowMessage("Success! Congratulations on adding a new employee", BunifuSnackbar.MessageTypes.Success);
                view.Reset();
            }
            OnPageChangedWhenChangeData();
        }

        private void OnPageChangedWhenChangeData()
        {
            StaffView view = InitClasses.staffView;
            int totalRows = (int)this.model.getNumberOfStaff(view.valueSearch)["number"];
            view.totalPages = (int)Math.Ceiling((double)totalRows / view.pageSize);

            int startIndex = (view.currentPage - 1) * view.pageSize + 1 > totalRows ? 1 : (view.currentPage - 1) * view.pageSize + 1;
            if (startIndex == 1)
            {
                view.currentPage = 1;
            }
            if (totalRows == 0)
            {
                startIndex = 0;
            }
            view.HandlePagination();
            view.CheckEnable();
            view.isClicked(view.currentPage.ToString());
            int endIndex = (view.currentPage) * view.pageSize > totalRows ? totalRows : (view.currentPage) * view.pageSize;
            var allStaff = this.model.getStaffByValue(view.valueSearch, startIndex - 1, endIndex - startIndex + 1);
            view.ClearGridView();
            view.displayStaff(allStaff);
            view.ChangeLabelOfShowing($"Showing {startIndex} to {endIndex} of {totalRows} entries");
        }
    }
}
