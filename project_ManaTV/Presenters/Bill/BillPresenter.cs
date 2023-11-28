using project_ManaTV.Repository;
using project_ManaTV.Views.FuncFrm.Bill;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Presenters.Bill
{
    internal class BillPresenter
    {
        private readonly BillDataTable view;
        private readonly BillRepository bR = new BillRepository();
        public BillPresenter(BillDataTable view)
        {
            this.view = view;

            view.GetNumberOfStaff += OnGetNumberOfBill;
            view.PageChanged += OnPageChanged;
        }

        private void OnPageChanged(object sender, EventArgs e)
        {
            if(view.status == 1)
            {
                int totalRows = (int)bR.GetNumberImportBill(view.valueSearch)["number"];
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
                var allImport = bR.GetAllImportBill(view.valueSearch, startIndex - 1, endIndex - startIndex + 1);
                // MessageBox.Show(totalRows + " + " + view.valueSearch);
                this.view.displayImportBill(allImport);
                view.ChangeLabelOfShowing($"Showing {startIndex} to {endIndex} of {totalRows} entries");
            }
            else
            {
                int totalRows = (int)bR.GetNumberSellBill(view.valueSearch)["number"];
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
                var allSell = bR.GetAllSellBill(view.valueSearch, startIndex - 1, endIndex - startIndex + 1);
                // MessageBox.Show(totalRows + " + " + view.valueSearch);
                this.view.displaySellBill(allSell);
                view.ChangeLabelOfShowing($"Showing {startIndex} to {endIndex} of {totalRows} entries");
            }

        }

        private void OnGetNumberOfBill(object sender, EventArgs e)
        {
            if(view.status == 1)
            {
                var data = bR.GetNumberImportBill(view.valueSearch);
                view.GetCountOfBill(data);
            }
            else
            {
                var data = bR.GetNumberSellBill(view.valueSearch);
                view.GetCountOfBill(data);
            }
            OnPageChanged(sender, e);

        }
    }
}
