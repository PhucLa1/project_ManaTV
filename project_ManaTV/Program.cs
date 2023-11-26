
using project_ManaTV.Presenters;
using project_ManaTV.Presenters.Staff;
using project_ManaTV.Views.FuncFrm.Bill;
using project_ManaTV.Views.FuncFrm.CustomerView;
using project_ManaTV.Views.FuncFrm.Dashboard;
using project_ManaTV.Views.FuncFrm.Login;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BillOverall(1));
            //Application.Run(new ListCustomers());
        }
    }
}
