using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.StaffManagement
{
    internal interface IAboutStaff
    {
        int id { get; set; }
        string status { get; set; }
        string name { get; set; }
        string phoneNumber { get; set; }
        string address { get; set; }
        string email { get; set; }
        bool gender { get; set; }
        string dob { get; set; }
        int id_Work { get; set; }

        event EventHandler UpdateData;
        event EventHandler DeleteData;
        event EventHandler AddData;
        event EventHandler LoadWorkData;
        event EventHandler LoadDataById;

        void AddWorkInDropDown(List<Dictionary<string, object>> workList);
        bool Valiadate();
        string getValueOfRadioButton(Panel panel);
        void resetOfRadioButton(Panel panel);
        void ShowMessage(string message,BunifuSnackbar.MessageTypes messageTypes);
        void ShowInformation(Dictionary<string, object> data);
        void Reset();
        //void ChangeEnable();
    }
}
