using Bunifu.UI.WinForms;
using project_ManaTV.Models;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Presenters.Staff
{
    internal class AddStaffPresenter
    {
        private readonly m_Staff model;
        private readonly IAddNewStaff view; 

        public AddStaffPresenter(m_Staff model,IAddNewStaff view)
        {
            this.view = view;
            this.model = model;


            AssociationLoadEvent();
        }

        private void AssociationLoadEvent()
        {
            this.view.AddData += OnAddData;
            this.view.LoadWorkData += OnLoadWorkData;
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
                this.view.ShowMessage("Thông tin nhập bị sai", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                this.model.AddNewStaff(this.view.name,
                    this.view.gender, this.view.phoneNumber, this.view.dob, this.view.address, this.view.email,
                    this.view.id_Work
                    );
                this.view.ShowMessage("Thành công", BunifuSnackbar.MessageTypes.Success);
            }
            var data = this.model.getAllStaff();
            InitClasses.staffView.ClearGridView();
            InitClasses.staffView.displayStaff(data);
        }
    }
}
