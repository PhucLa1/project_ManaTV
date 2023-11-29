using project_ManaTV.Models;
using project_ManaTV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Presenters.Login
{
    public class LoginPresenter
    {
        private LoginRespository loginRespository = new LoginRespository();
        public LoginPresenter() { }
        //Check dang nhap
        public bool checkLogin(Admin admin)
        {
            return loginRespository.checkLogin(admin);
        }

        //Show pass
        public string showPass(string username)
        {
            if(loginRespository.checkUser(username))
            {
                return loginRespository.showPass(username);
            }
            return "";
        }
    }
}
