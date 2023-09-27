using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Presenters.Staff;
using project_ManaTV.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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


        private int CurrentPage = 1;
        private int PageSize = 10;
        private int TotalPage;
        private int TotalRows;
        public int currentPage {
            get { return CurrentPage; } 
            set { CurrentPage = value; } 
        }
        public int pageSize {
            get { return PageSize; }
            set { PageSize = value; }
        }

        public int totalPages {
            get { return TotalPage; }
            set { TotalPage = value; }
        }
        public int totalRows
        {
            get { return TotalRows; }
            set { TotalRows = value; }
        }

        public StaffView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        public string valueSearch
        {
            get { return txtSearch.Text.Trim(); }
            set { txtSearch.Text = value; }
        }

        private void AssociateAndRaiseViewEvents()
        {

            
            //Sự kiện tìm kiếm
            try
            {
                btnSrc.Click += delegate { SearchData?.Invoke(this, EventArgs.Empty); };
                txtSearch.KeyUp += (s, e) =>
                {
                    //MessageBox.Show(txtSearch.Text); // Giá trị của txtSearch.Text đã được cập nhật ở đây.
                    SearchData?.Invoke(this, EventArgs.Empty);
                };

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Sự kiện thay đổi dữ liệu trong datagridview
            gridViewStaff.CellContentClick += (s, e) =>
            {
                int actions = e.ColumnIndex;
                if (actions >= 8)
                {
                    
                    int x = int.Parse(gridViewStaff.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(actions + "");
                    StaffRepository m_Staff = new StaffRepository();
                    if (actions == 8)
                    {
                        if (InitClasses.UpdateStaff == null || InitClasses.UpdateStaff.IsDisposed)
                        {
                            InitClasses.UpdateStaff = new AboutStaff(x, "Update");
                        }
                        AboutStaffPresenter UpdatePresenter = new AboutStaffPresenter(m_Staff, InitClasses.UpdateStaff);
                        InitClasses.UpdateStaff.Show();
                    }
                    else if (actions == 9)
                    {
                        if (InitClasses.DetailStaff == null || InitClasses.DetailStaff.IsDisposed)
                        {
                            InitClasses.DetailStaff = new AboutStaff(x, "Detail");
                        }
                        AboutStaffPresenter DetailStaffPresenter = new AboutStaffPresenter(m_Staff, InitClasses.DetailStaff);
                        InitClasses.DetailStaff.Show();
                    }
                    else if (actions == 10)
                    {
                        if (InitClasses.DeleteStaff == null || InitClasses.DeleteStaff.IsDisposed)
                        {
                            InitClasses.DeleteStaff = new AboutStaff(x, "Delete");
                        }
                        AboutStaffPresenter DeleteStaffPresenter = new AboutStaffPresenter(m_Staff, InitClasses.DeleteStaff);
                        InitClasses.DeleteStaff.Show();
                    }
                }
                
            };

            //Sự kiện đổi trang dữ liệu
            
            btnPrev.Enabled = false;
            CheckEnable();

            
            btnPrev.Click += (s, e) =>
            {
                btnNext.Enabled = true;
                if (CurrentPage > 2 )
                {
                    CurrentPage--;
                    btnPrev.Enabled = true;
                }
                else
                {
                    CurrentPage--;
                    btnPrev.Enabled = false;
                }
                PageChanged?.Invoke( this, EventArgs.Empty );
              
            };

            btnNext.Click += (s, e) =>
            {
                btnPrev.Enabled = true;
                if (CurrentPage < TotalPage -1 )
                {
                    btnNext.Enabled = true;
                    CurrentPage += 1;
                }
                else
                {
                    CurrentPage++;
                    btnNext.Enabled = false;
                }
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            btnFirst.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnFirst.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            btnSecond.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnSecond.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);              
            };
            btnThird.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnThird.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };
            btnFourth.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnFourth.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            btnFive.Click += (s, e) =>
            {
                CurrentPage = int.Parse(btnFive.Text);
                PageChanged?.Invoke(this, EventArgs.Empty);
            };

            //Su kien thay doi dong
            ddRows.SelectedIndexChanged += (s, e) =>
            {
                PageSize = int.Parse(ddRows.SelectedItem.ToString()); 
                CountPageChanged?.Invoke(this, EventArgs.Empty);
            };



        }


        public event EventHandler SearchData;
        public event EventHandler CountPageChanged;
        public event EventHandler GetNumberOfStaff;
        public event EventHandler PageChanged;

        public void HandlePagination()
        {
            //MessageBox.Show(TotalPage + " "+ CurrentPage);
            btnSecond.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = true;
            btnFive.Visible = true;
            if (TotalPage == 1)
            {
                btnSecond.Visible = false;
                btnThird.Visible = false;
                btnFourth.Visible = false;
                btnFive.Visible = false;
            }
            else if (TotalPage == 2)
            {
                btnThird.Visible = false;
                btnFourth.Visible = false;
                btnFive.Visible = false;
            }
            else if (TotalPage == 3)
            {
                btnFourth.Visible = false;
                btnFive.Visible = false;
            }
            else if (TotalPage == 4)
            {
                btnFive.Visible = false;
            }

            //Chuyển số nếu trang quá trang
            ChangePage();
            
        }
        private void ChangePage()
        {
            int first = int.Parse(btnFirst.Text);
            int second = int.Parse(btnSecond.Text);
            int third = int.Parse (btnThird.Text);
            int fourth = int.Parse(btnFourth.Text);
            int fiveth = int.Parse(btnFive.Text);
            if (TotalPage > 5)
            {
                if(TotalPage - 1 >= fiveth)
                {
                    if(currentPage == fourth || currentPage == fiveth)
                    {
                        btnFirst.Text = (first + 1).ToString();
                        btnSecond.Text = (second + 1).ToString();
                        btnThird.Text = (third + 1).ToString();
                        btnFourth.Text = (fourth + 1).ToString();
                        btnFive.Text = (fiveth + 1).ToString();
                    }
                }else if(TotalPage - 2 >= fiveth)
                {
                    if (currentPage == fiveth)
                    {
                        btnFirst.Text = (first + 2).ToString();
                        btnSecond.Text = (second + 2).ToString();
                        btnThird.Text = (third + 2).ToString();
                        btnFourth.Text = (fourth + 2).ToString();
                        btnFive.Text = (fiveth + 2).ToString();
                    }
                }else if(first - 1 > 0)
                {
                    if(currentPage == second || currentPage == first)
                    {
                        btnFirst.Text = (first - 1).ToString();
                        btnSecond.Text = (second - 1).ToString();
                        btnThird.Text = (third - 1).ToString();
                        btnFourth.Text = (fourth - 1).ToString();
                        btnFive.Text = (fiveth - 1).ToString();
                    }
                }else if(first - 2 > 0)
                {
                    btnFirst.Text = (first - 2).ToString();
                    btnSecond.Text = (second - 2).ToString();
                    btnThird.Text = (third - 2).ToString();
                    btnFourth.Text = (fourth - 2).ToString();
                    btnFive.Text = (fiveth - 2).ToString();
                }
            //    if(currentPage == fourth)
            //    {
            //        if(TotalPage - 1 >= fiveth)
            //        {
            //            btnFirst.Text = (first + 1).ToString();
            //            btnSecond.Text = (second + 1).ToString();
            //            btnThird.Text = (third + 1).ToString();
            //            btnFourth.Text = (fourth + 1).ToString();
            //            btnFive.Text = (fiveth + 1).ToString();
            //        }

            //    }else if(currentPage == fiveth)
            //    {
            //        if(TotalPage - 2 >= fiveth)
            //        {
            //            btnFirst.Text = (first + 2).ToString();
            //            btnSecond.Text = (second + 2).ToString();
            //            btnThird.Text = (third + 2).ToString();
            //            btnFourth.Text = (fourth + 2).ToString();
            //            btnFive.Text = (fiveth + 2).ToString();
            //        }else if(TotalPage - 1 >= fiveth)
            //        {
            //            btnFirst.Text = (first + 1).ToString();
            //            btnSecond.Text = (second + 1).ToString();
            //            btnThird.Text = (third + 1).ToString();
            //            btnFourth.Text = (fourth + 1).ToString();
            //            btnFive.Text = (fiveth + 1).ToString();
            //        }
            //    }
            //    else if(currentPage == second)
            //    {
            //        if(first - 1 > 0)
            //        {
            //            btnFirst.Text = (first - 1).ToString();
            //            btnSecond.Text = (second - 1).ToString();
            //            btnThird.Text = (third - 1).ToString();
            //            btnFourth.Text = (fourth - 1).ToString();
            //            btnFive.Text = (fiveth - 1).ToString();
            //        }

            //    }else if(currentPage == first)
            //    {
            //        if(first - 2 > 0)
            //        {
            //            btnFirst.Text = (first - 2).ToString();
            //            btnSecond.Text = (second - 2).ToString();
            //            btnThird.Text = (third - 2).ToString();
            //            btnFourth.Text = (fourth - 2).ToString();
            //            btnFive.Text = (fiveth - 2).ToString();
            //        }else if(first - 1>0)
            //        {
            //            btnFirst.Text = (first - 1).ToString();
            //            btnSecond.Text = (second - 1).ToString();
            //            btnThird.Text = (third - 1).ToString();
            //            btnFourth.Text = (fourth - 1).ToString();
            //            btnFive.Text = (fiveth - 1).ToString();
            //        }
            //    }

            }
            //MessageBox.Show(currentPage.ToString());
        }
        public void displayStaff(List<Dictionary<string, object>> staffList)
        {
            //Ở đây rows 1 trang là 10;



            HandleGridView.SetMiddleCenter(7, gridViewStaff);

            Image imagePen = HandleImage.ZoomOutImage(HandleImage.filePath("Others", "pen.png"));
            Image imageEye = HandleImage.ZoomOutImage(HandleImage.filePath("Others", "eye.png"));
            Image imageBin = HandleImage.ZoomOutImage(HandleImage.filePath("Others", "bin.png"));


            foreach (var item in staffList)
            {
                
                Image imageGen = ((bool)item["staff_gender"] == true)?
                    HandleImage.ZoomOutImage(HandleImage.filePath("Others", "male.png")):
                    HandleImage.ZoomOutImage(HandleImage.filePath("Others","female.png"));
                

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
                        imagePen,imageEye,imageBin
                    }
                    );
            }

        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            GetNumberOfStaff?.Invoke(this, EventArgs.Empty);         
        }
        public void ClearGridView()
        {
            gridViewStaff.Rows.Clear();
        }

        public void ChangeLabelOfShowing(string label)
        {
            lbShowing.Text = label;
        }

        public void GetCountOfStaff(Dictionary<string, object> numberStaff)
        {
            ddRows.Text = "10";
            TotalRows = (int)numberStaff["number"];
            TotalPage = (int)Math.Ceiling((double)((int)numberStaff["number"]) / PageSize);
        }
        public void isClicked(string search)
        {
            foreach (Control control in pagination.Controls)
            {
                if (control is BunifuButton button)
                {
                    if (button.Text != search)
                    {
                        button.IdleFillColor = Color.Transparent;
                    }
                    else
                    {
                        button.IdleFillColor = Color.FromArgb(40, 96, 144);
                        
                    }

                }
            }

        }
        public void CheckEnable()
        {
            if (CurrentPage < TotalPage)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }if(CurrentPage > 1)
            {
                btnPrev.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;
            }
        }



    }
}
