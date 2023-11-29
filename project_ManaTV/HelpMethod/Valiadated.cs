using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project_ManaTV.HelpMethod
{
    public static  class Valiadated
    {
        public static bool checkEmail(string email)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            bool isMatch = Regex.IsMatch(email, pattern);
            return isMatch;
        }
        public static bool checkPhone(string phone)
        {
            string pattern = @"^\d{10}$";
            bool isMatch = Regex.IsMatch(phone, pattern);
            return isMatch;
        }
        public static bool checkName(string name)
        {
            string pattern = @"^[a-zA-Z\s]{2,30}$";
            bool isMatch = Regex.IsMatch(name, pattern);
            return isMatch;
        }
        public static bool checkDropDown(Bunifu.Framework.UI.BunifuDropdown dd)
        {
            bool res = true;
            if(dd.selectedIndex == -1)
            {
                res = false;
            }
            return res;
        }

    }
}
