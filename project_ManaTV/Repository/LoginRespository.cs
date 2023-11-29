using project_ManaTV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Repository
{
    public class LoginRespository
    {
        Database db = new Database();
        public bool checkLogin(Admin admin)
        {
            string query = "select * from Admins where username = @username and pass = @pass";
            db.SetQuery(query);
            var res = db.LoadRow(admin.UserName, admin.Password);
            if (res.Count > 0) //Co gia tri
            {
               return true;
            }
            return false;
        }
        public bool checkUser(string username)
        {
            string query = "select * from Admins where username = @username";
            db.SetQuery(query);
            if(db.LoadRow(username).Count > 0)
            {
                return true;
            }
            return false;
        }
        public string showPass(string username)
        {
            string query = "select * from Admins where username = @username";
            db.SetQuery(query);
            return db.LoadRow(username)["username"].ToString();
        }
    }
}
