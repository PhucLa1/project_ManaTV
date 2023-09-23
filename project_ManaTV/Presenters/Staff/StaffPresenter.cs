using Bunifu.UI.WinForms;
using project_ManaTV.Models;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        private readonly m_Staff model;

        public StaffPresenter(IStaffView view, m_Staff model)
        {
            this.view = view;
            this.model = model;

            AssociationLoadEvent();
        }
        private void AssociationLoadEvent()
        {
            view.SearchData += OnSearchData;
            view.CountPageChanged += OnCountPageChanged;
            view.GetNumberOfStaff += OnGetNumberOfStaff;
            view.PageChanged += OnPageChanged;
        }

        private void OnPageChanged(object sender, EventArgs e)
        {
            int totalRows = (int)this.model.getNumberOfStaff(view.valueSearch)["number"];           
            view.totalPages = (int)Math.Ceiling((double)totalRows / view.pageSize);            
            int startIndex = (view.currentPage - 1) * view.pageSize + 1 > totalRows ? 1 : (view.currentPage - 1) * view.pageSize + 1;
            if (startIndex == 1)
            {
                view.currentPage = 1;
            }
            if(totalRows == 0)
            {
                startIndex = 0;
            }
            view.HandlePagination();
            view.CheckEnable();
            view.isClicked(view.currentPage.ToString());
            int endIndex = (view.currentPage) * view.pageSize > totalRows ? totalRows : (view.currentPage) * view.pageSize;
            var allStaff = this.model.getStaffByValue(view.valueSearch,startIndex - 1, endIndex - startIndex + 1);
           // MessageBox.Show(totalRows + " + " + view.valueSearch);
            this.view.ClearGridView();
            this.view.displayStaff(allStaff);
            view.ChangeLabelOfShowing($"Showing {startIndex} to {endIndex} of {totalRows} entries");
            //MessageBox.Show(view.valueSearch);
        }

        private void OnGetNumberOfStaff(object sender, EventArgs e)
        {
            var data = this.model.getNumberOfStaff(view.valueSearch);        
            view.GetCountOfStaff(data);
            OnPageChanged(sender, e);
        }

        private void OnCountPageChanged(object sender, EventArgs e)
        {
            OnPageChanged(sender, e);
        }

        private void OnSearchData(object sender, EventArgs e)
        {
            //MessageBox.Show(view.valueSearch);
            OnPageChanged(sender, e);
        }
    }
}
