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
       
        //Event
        event EventHandler LoadData;
        event EventHandler SearchData;
        event EventHandler UpdateData;


        void displayStaff(List<Dictionary<string, object>> staffList);
        void ClearGridView();

    }
}
