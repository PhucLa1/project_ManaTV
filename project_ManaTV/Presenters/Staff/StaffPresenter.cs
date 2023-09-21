using Bunifu.UI.WinForms;
using project_ManaTV.Repository;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuDataGridView.Transitions;

namespace project_ManaTV.Presenters
{
    internal class StaffPresenter
    {
        private readonly IStaffView view;
        private readonly StaffRepository model;

        public StaffPresenter(IStaffView view, StaffRepository model)
        {
            this.view = view;
            this.model = model;

            AssociationLoadEvent();
        }
        private void AssociationLoadEvent()
        {
            this.view.LoadData += OnLoadData;
            this.view.SearchData += OnSearchData;
            this.view.UpdateData += OnUpdataData;
        }

        private void OnUpdataData(object sender, EventArgs e)
        {

        }

        private void OnSearchData(object sender, EventArgs e)
        {
            var data = this.model.getStaffByValue(this.view.valueSearch);
            this.view.ClearGridView();
            this.view.displayStaff(data);
        }

        private void OnLoadData(object sender, EventArgs e)
        {
            var data = this.model.getAllStaff();
            this.view.ClearGridView();
            this.view.displayStaff(data);
        }

    }
}
