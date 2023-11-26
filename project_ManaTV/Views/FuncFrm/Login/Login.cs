using Bunifu.UI.WinForms;
using project_ManaTV.Models;
using project_ManaTV.Presenters.Login;
using project_ManaTV.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.Login
{
    public partial class Login : Form
    {
        private LoginPresenter loginPresenter = new LoginPresenter();
        public static string Pass;
        public Login()
        {
            InitializeComponent();
        }
        private Admin setData()
        {
            return new Admin()
            {
                UserName = txtUser.Text,
                Password = txtPass.Text
            };
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = setData();
            var res = loginPresenter.checkLogin(admin);
            if (res == true)
            {
                ShowMessage("Sign in successfully !!!", BunifuSnackbar.MessageTypes.Success);
                //this.Dispose();
                InitClasses.layout.Show();
            }
            else
            {
                ShowMessage("Error username or password !!!", BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void ShowMessage(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            Notice.Show(this, message,messageTypes,1000,"",BunifuSnackbar.Positions.TopRight);
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {
            ChangePass cP = new ChangePass();
            cP.Show();
            cP.continueClick += (s, ev) =>
            {
                string res = loginPresenter.showPass(cP.text);
                if(res == "")
                {
                    Pass = "The username is not alreay exsist";
                }
                else
                {
                    Pass = "Your password is : " + res;
                }
            };
        }
    }
}
