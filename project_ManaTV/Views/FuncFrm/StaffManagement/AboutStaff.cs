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
using project_ManaTV.HelpMethod;
using System.Web;

namespace project_ManaTV
{
    public partial class AboutStaff : Form, IAboutStaff
    {
        //private Bitmap defaultImage;
        public Form FRM_LAYOUT { get; set; }//thêm FRM_Layout
        private int Id;
        private string Status;
        private bool Gend;
        public AboutStaff(int id, string status)
        {
            //tes pussh
            InitializeComponent();
            //Sự kiện clear các field và làm mất tầm nhìn của cái panel
            this.Id = id;
            this.Status = status;
            ShowFormByStatus();
            //Sự kiện Add
            btnSave.Click += delegate {
                //MessageBox.Show(Id+"");
                if (Id == -1)
                {
                    AddData?.Invoke(this, EventArgs.Empty);
                }
                else if (Status == "Update")
                {
                    //MessageBox.Show("1");
                    UpdateData?.Invoke(this, EventArgs.Empty);
                }
                else if (Status == "Delete")
                {
                    DeleteData?.Invoke(this, EventArgs.Empty);
                }

            };
        }


        private void ShowFormByStatus()
        {
            this.Text = Status;
            btnSave.Text = Status;
                btnOther.Text = "Return";
                if (Status == "Delete")
                {
                    lbConfirm.Visible = true;
                }


        }



        public event EventHandler AddData;
        public event EventHandler LoadWorkData;
        public event EventHandler LoadDataById;
        public event EventHandler UpdateData;
        public event EventHandler DeleteData;

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



        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
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
                    return radioButton.Name;
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
            lbAddressEr.Text = ""; lbNameEr.Text = "";
            lbPhoneEr.Text = ""; lbDobEr.Text = "";
            lbGenderEr.Text = ""; lbEmailEr.Text = "";
            lbWorkEr.Text = "";

            //Check name
            if(Valiadated.checkName(txtName.Text) == false)
            {
                res = false; lbNameEr.Text = "Name was not entered in the correct format";
            }
            if(name == "") { res = false; lbNameEr.Text = "Name cannot be empty"; }

            //Check email
            if(Valiadated.checkEmail(email) == false) { res = false; lbEmailEr.Text = "Email was not entered in the correct format"; }
            if (email == "") { res = false; lbEmailEr.Text = "Email cannot be empty"; }

            //Check phone number
            if (Valiadated.checkPhone(phoneNumber) == false) { res = false; lbPhoneEr.Text = "Phonenumber was not entered in the correct format"; }
            if (email == "") { res = false; lbPhoneEr.Text = "Phonenumber cannot be empty"; }

            //Check dropdown work
            if(Work.SelectedIndex == -1) { res = false; lbWorkEr.Text = "Staff role cannot be empty"; }

            //Check address
            if (address == "") { res = false; lbAddressEr.Text = "Address cannot be empty"; }

            //Check gender
            if(getValueOfRadioButton(panel1) == "") { res = false; lbGenderEr.Text = "Please choose your gender"; MessageBox.Show("1"); }

            //Check DOB
            if(days.Text == "" || month.Text == "" || year.Text == "") { res = false; lbDobEr.Text = "Please enter your date of birth"; }
            return res;

        }


        private void AddNewStaff_Load(object sender, EventArgs e)
        {
            LoadWorkData?.Invoke(this, EventArgs.Empty);
            if (Id != -1)
            {
                LoadDataById?.Invoke(this, EventArgs.Empty);
                if (Status != "Update")
                {
                    UnEnable();
                }
            }
            SetStatusForDatePicker();

        }
        public void ShowInformation(Dictionary<string, object> value)
        {
            txtEmail.Text = (string)value["staff_email"];
            txtAddress.Text = (string)value["staff_address"];
            txtName.Text = (string)value["staff_name"];
            txtPhone.Text = (string)value["staff_phoneNumber"];
            Work.SelectedIndex = (int)value["staff_work_id"] - 1;
            //Work.Text = (string)value["work_name"];
            DateTime staffDOB = (DateTime)value["staff_dob"];
            string staffDOBString = staffDOB.ToString(); // Chuyển đổi thành chuỗi
            dobPicker.Text = staffDOBString;
            year.Text = dobPicker.Value.Year.ToString();
            month.Text = dobPicker.Value.Month.ToString();
            days.Text = dobPicker.Value.Day.ToString();
            if ((bool)value["staff_gender"] == true)
            {
                Male.Checked = true;
                Female.Checked = false;
            }
            else
            {
                Male.Checked = false;
                Female.Checked = true;
            }
            if ((string)value["staff_image"] != null || (string)value["staff_image"] != "")
            {
                ImageUser.Image = HandleImage.filePath("Users",(string)value["staff_image"]);
            }
            else
            {
                ImageUser.Image = HandleImage.filePath("Users", "person.png");
            }
        }


        //Những sự kiện UI

        public void Reset()
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            resetOfRadioButton(panel1);
            Work.SelectedIndex = -1;
            year.Text = "";
            month.Text = "";
            days.Text = "";
            ImageUser.Image = HandleImage.filePath("Others","person.png");
        }

        private void UnEnable()
        {
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            Work.Enabled = false;
            Male.Enabled = false;
            Female.Enabled = false;
            year.Enabled = false;
            month.Enabled = false;
            days.Enabled = false;
            dobPicker.Enabled = false;

        }

        private void SetStatusForDatePicker()
        {
            for (int i = 1990; i <= 2020; i++)
            {
                year.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                string x = i.ToString();
                if (i < 10)
                {
                    x = "0" + x;
                }
                month.Items.Add(x);
            }
            for (int i = 1; i <= 31; i++)
            {
                string x = i.ToString();
                if (i < 10)
                {
                    x = "0" + x;
                }
                days.Items.Add(x);
            }
        }





        //Xử lí di chuyển form

        private bool isDragging = false;
        private Point lastLocation;
        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location;
            }
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void dobPicker_ValueChanged_1(object sender, EventArgs e)
        {
            year.Text = dobPicker.Value.Year.ToString();
            month.Text = dobPicker.Value.Month.ToString();
            days.Text = dobPicker.Value.Day.ToString();
        }

        //Mở chọn ảnh

        private void ImageUser_Click(object sender, EventArgs e)
        {
            HandleImage.OpenImageAndShow(ImageUser);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        //Xử lí valiadate






    }
}
