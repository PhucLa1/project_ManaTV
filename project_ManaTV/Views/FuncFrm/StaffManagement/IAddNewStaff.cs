using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.StaffManagement
{
    internal interface IAddNewStaff
    {
        string name { get; set; }
        string phoneNumber { get; set; }
        string address { get; set; }
        string email { get; set; }
        bool gender { get; set; }
        string dob { get; set; }
        int id_Work { get; set; }


        event EventHandler AddData;
        event EventHandler LoadWorkData;

        void AddWorkInDropDown(List<Dictionary<string, object>> workList);
        bool Valiadate();
        string getValueOfRadioButton(Panel panel);
        void resetOfRadioButton(Panel panel);
        void ShowMessage(string message,BunifuSnackbar.MessageTypes messageTypes);
        //void ChangeEnable();
    }
}
