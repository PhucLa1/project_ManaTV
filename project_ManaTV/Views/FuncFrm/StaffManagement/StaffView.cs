using Bunifu.UI.WinForms;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuDataGridView.Transitions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace project_ManaTV.Views.FuncFrm.StaffManagement
{
    public partial class StaffView : Form, IStaffView
    {

        //----------------------------------------------------------------------------
        //Các attribute
        public string valueSearch
        {
            get { return txtSearch.Text.Trim(); }
            set { txtSearch.Text = value; }
        }
        public StaffView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();


        }

        private void AssociateAndRaiseViewEvents()
        {
            //Sự kiện tìm kiếm
            try
            {
                btnSrc.Click += delegate { SearchData?.Invoke(this, EventArgs.Empty); };
                txtSearch.KeyDown += (s, e) =>
                {
                    SearchData?.Invoke(this, EventArgs.Empty);
                };
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Sự kiện thay đổi dữ liệu trong datagridview
            gridViewStaff.CellEndEdit += (sender, e) => UpdateData?.Invoke(this,e);


        }

        public event EventHandler LoadData;
        public event EventHandler SearchData;
        public event EventHandler UpdateData;

        public void displayStaff(List<Dictionary<string, object>> staffList)
        {

            HandleGridView.SetMiddleCenter(8, gridViewStaff);

            foreach (var item in staffList)
            {
                
                Image imageGen = ((bool)item["staff_gender"] == true)?
                    HandleImage.ZoomOutImage(HandleImage.filePath("Others", "male.png")):
                    HandleImage.ZoomOutImage(HandleImage.filePath("Others","female.png"));
                Image imageOther = HandleImage.ZoomOutImage(HandleImage.filePath("Others", "more.png"));

                gridViewStaff.Rows.Add(
                    new object[]
                    {
                        item["staff_id"],
                        item["staff_name"],
                        imageGen,
                        item["staff_phoneNumber"],
                        item["staff_dob"],
                        item["staff_address"],
                        item["staff_email"],
                        item["work_name"],
                        imageOther
                    }
                    );

            }
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            LoadData?.Invoke(this, EventArgs.Empty);
        }



        public void ClearGridView()
        {
            gridViewStaff.Rows.Clear();
        }





        //Xử lí UI
        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        { 
            m_Staff m_Staff = new m_Staff();
            AddStaffPresenter addStaffPresenter = new AddStaffPresenter(m_Staff,InitClasses.AddNewStaff);
            InitClasses.AddNewStaff.Show();
        }

        private void gridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8)
            {
                BunifuDropdown actions = new BunifuDropdown();

                actions.Color = Color.White;
                //Them cac lua chon
                actions.Items.Add("Option 1");
                actions.Items.Add("Option 2");
                actions.Items.Add("Option 3");

                Rectangle cellRectangle = gridViewStaff.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                actions.Location = new Point(cellRectangle.X, cellRectangle.Bottom);

                gridViewStaff.Controls.Add(actions);
            }
        }
    }
}
