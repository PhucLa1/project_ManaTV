using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace project_ManaTV.Views.FuncFrm.StaffManagement
{
    internal interface IStaffView
    {

        //Attribute
        string valueSearch { get; set; }
        int currentPage { get; set; }
        int pageSize { get; set; }
        int totalPages { get; set; }  
        int totalRows { get; set; }


        //Event
        event EventHandler SearchData;
        event EventHandler CountPageChanged;
        event EventHandler GetNumberOfStaff;
        event EventHandler PageChanged;


        void displayStaff(List<Dictionary<string, object>> staffList);
        void ClearGridView();
        void HandlePagination();
        void ChangeLabelOfShowing(string label);
        void GetCountOfStaff(Dictionary<string, object> numberStaff);
        void isClicked(string search);
        void CheckEnable();
        void ShowMessageOfDel(string message, BunifuSnackbar.MessageTypes messageTypes);
        //
    }
}
