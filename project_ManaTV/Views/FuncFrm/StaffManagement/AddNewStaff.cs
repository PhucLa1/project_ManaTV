using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using System.IO;
using project_ManaTV.Views.FuncFrm.StaffManagement;

namespace project_ManaTV
{
    public partial class AddNewStaff : Form, IAddNewStaff
    {
        //private Bitmap defaultImage;
        public AddNewStaff()
        {
            InitializeComponent();
            //Sự kiện clear các field và làm mất tầm nhìn của cái panel

            //Sự kiện Add
            btnAdd.Click += delegate { AddData?.Invoke(this, EventArgs.Empty); };
        }
        private bool Gend;

        public event EventHandler AddData;
        public event EventHandler LoadWorkData;

        public string name
        {
            get { return txtName.Text.Trim(); }
            set { txtName.Text = value; }
        }
        public string phoneNumber
        {
            get { return txtPhone.Text.Trim(); }
            set { txtName.Text = value; }
        }
        public string address
        {
            get { return txtAddress.Text.Trim(); }
            set { txtName.Text = value; }
        }
        public string email
        {
            get { return txtEmail.Text.Trim(); }
            set { txtName.Text = value; }
        }
        public bool gender
        {
            get
            {
                Gend = (getValueOfRadioButton(panel1) == "Male") ? true : false;
                return Gend;
            }
            set { Gend = value; }
        }
        public string dob
        {
            get { return dobPicker.Text; }
            set { dobPicker.Text = value; }
        }
        public int id_Work
        {
            get { return Work.SelectedIndex + 1; }
            set
            {
                int res = Work.SelectedIndex + 1;
                res = value;
            }
        }
        //-------------------------------------------------------------------------------------

        public void ShowMessage(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            bunifuSnackbar1.Show(this, message,
            messageTypes,
            1000,
            "",
            BunifuSnackbar.Positions.TopRight);
        }
        public string getValueOfRadioButton(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is BunifuRadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.BindingControl.Text;
                }
            }

            return "";
        }
        public void resetOfRadioButton(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is BunifuRadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

        }

        public void AddWorkInDropDown(List<Dictionary<string, object>> workList)
        {
            foreach (var work in workList)
            {
                Work.Items.AddRange(
                new String[]
               {
                   (string)work["work_name"]
               }
            );
            }
        }



        public bool Valiadate()
        {
            bool res = true;
            if (name == "" || address == "" || phoneNumber == "" || email == "" || getValueOfRadioButton(panel1) == ""
                || Work.SelectedIndex == -1)
            {
                res = false;
            }
            return res;

        }


        private void AddNewStaff_Load(object sender, EventArgs e)
        {
            LoadWorkData?.Invoke(this, EventArgs.Empty);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getValueOfRadioButton(panel1));
        }
    }
}
