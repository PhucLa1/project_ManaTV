using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.Presenters;
using project_ManaTV.Presenters.Staff;
using project_ManaTV.Repository;
using project_ManaTV.Views;
using project_ManaTV.Views.FuncFrm.StaffManagement;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace project_ManaTV
{


    //Sẽ lấy hết tất cả ở đây

    public partial class Frm_Layout : Form
    {
        FontFamily[] fontFamilies;
        public Frm_Layout()
        {
            InitializeComponent();
            setSizeForm();
            InitForm();
        }




        private void InitForm()
        {

            lblBrandName.ForeColor = ColorTranslator.FromHtml("#30B9DB");
            searchFunction.FillColor = ColorTranslator.FromHtml("#ECF1F8");
            searchFunction.BorderColorActive = ColorTranslator.FromHtml("#D9D9D9");
            sidebar.BackColor = ColorTranslator.FromHtml("#29374B");

           

            var lstMenuButtons = new List<BunifuButton>() { btnDashboard , btnLogOut , btnProduct , btnStaff };
            foreach (var btn in lstMenuButtons)
            {
                CustomMenuButton(btn);
            }
        }
        private void CustomMenuButton(BunifuButton menuButton)
        {
            menuButton.IdleFillColor = Color.Transparent;
            menuButton.onHoverState.BorderColor = Color.Transparent;
            menuButton.onHoverState.FillColor = Color.FromArgb(72, 217, 217, 217);
            menuButton.onHoverState.ForeColor = ColorTranslator.FromHtml("#D9D9D9");
            menuButton.onHoverState.BorderRadius = 0;

            menuButton.OnPressedState.BorderColor = Color.Transparent;
            menuButton.OnPressedState.FillColor = Color.FromArgb(72, 217, 217, 217);
            menuButton.OnPressedState.ForeColor = Color.FromArgb(72, 217, 217, 217);



            //Font
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.Lexend_Regular.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Lexend_Regular;

            // create an unsafe memory block for the font data
            var data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            //pfc.AddMemoryFont(data, fontLength);
            //btnProduct.Font = new Font(pfc.Families[0], lblBrandName.Font.Size);
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panelMainContent.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(formToShow);

            // Đặt lại vị trí và kích thước của form con
            formToShow.Location = new Point(0, 0); // Đặt vị trí ở góc trên bên trái của panel
            formToShow.Size = panelMainContent.Size; // Đặt kích thước bằng kích thước của panel

            // Hiển thị form con
            formToShow.Show();
            
        }


        public void setSizeForm()
        {
            this.Left = 130;
            this.Top = 130;
            this.Width = 1120;
            this.Height = 684;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool productExpand = false;
        private void productTrans_Tick(object sender, EventArgs e)
        {
            if (productExpand == false)
            {
                productSideBar.Height += 10;
                if (productSideBar.Height >= 235)
                {
                    productExpand = true;
                    productTrans.Stop();
                }
            }
            else
            {
                productSideBar.Height -= 10;
                if (productSideBar.Height <= 55)
                {
                    productExpand = false;
                    productTrans.Stop();
                }
            }
        }



        private void startFormLoad()
        {

        }
        private int x;
        private int y;
        private void Form1_Load(object sender, EventArgs e)
        {

            x = this.Left;
            y = this.Top;
        }


        //Lay anh tu image
        

        private bool staffExpand = false;
        private void staffTrans_Tick(object sender, EventArgs e)
        {
            if (staffExpand == false)
            {
                staffSideBar.Height += 10;
                if (staffSideBar.Height >= 152)
                {
                    staffExpand = true;
                    staffTrans.Stop();
                }
            }
            else
            {
                staffSideBar.Height -= 10;
                if (staffSideBar.Height <= 55)
                {
                    staffExpand = false;
                    staffTrans.Stop();
                }
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            staffTrans.Start();


        }

        private void searchFunction_TextChanged(object sender, EventArgs e)
        {
            Dictionary<Control, string> buttonValues = GetButtonValuesFromPanels(sidebar);
            string text = searchFunction.Text.ToLower();
            foreach (KeyValuePair<Control, string> kvp in buttonValues)
            {
                if (!kvp.Value.Contains(text))
                {
                    kvp.Key.Visible = false;
                }
                else
                {
                    kvp.Key.Visible = true;
                }
            }
        }
        private Dictionary<Control, string> GetButtonValuesFromPanels(FlowLayoutPanel panel)
        {
            Dictionary<Control, string> buttonValues = new Dictionary<Control, string>();
            foreach (Control control in panel.Controls)
            {
                if (control is FlowLayoutPanel subPanel)
                {

                    foreach (Control subControl in subPanel.Controls)
                    {

                        if (subControl is BunifuButton button)
                        {
                            buttonValues.Add(button, button.Text.ToLower());
                        }
                    }
                }
                else if (control is BunifuButton button)
                {
                    buttonValues.Add(button, button.Text.ToLower());
                }
            }

            return buttonValues;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();

        }

        private bool sidebarExpand = true;
        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 266)
                {
                    sidebarExpand = true;
                    sidebarTrans.Stop();
                    setButtonWidth();

                }
            }
            else
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 61)
                {
                    sidebarExpand = false;
                    sidebarTrans.Stop();
                    setButtonWidth();
                }
            }
        }

        private void setButtonWidth()
        {
            btnLogOut.Width = sidebar.Width;
            btnStaff.Width = sidebar.Width;
            btnProduct.Width = sidebar.Width;
            btnDashboard.Width = sidebar.Width; 
        }



        private void btnProduct_Click(object sender, EventArgs e)
        {
            productTrans.Start();
        }



        private bool isDragging = false;
        private int mouseX, mouseY;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }


        private bool isZoomed = false;
        private int targetWidth;
        private int targetHeight;


        private void zoom_Tick(object sender, EventArgs e)
        {
            if (btnHam.Width < targetWidth)
                btnHam.Width += 1;
            if (btnHam.Height < targetHeight)
                btnHam.Height += 1;

            // Kiểm tra xem nút đã phóng to đủ lớn chưa
            if (btnHam.Width >= targetWidth && btnHam.Height >= targetHeight)
            {
                isZoomed = true;
                zoom.Stop();
            }
        }

        private void btnHam_MouseEnter(object sender, EventArgs e)
        {
            //targetWidth = btnHam.Width + 10; // Ví dụ: tăng 20 pixel
            //targetHeight = btnHam.Height + 10; // Ví dụ: tăng 20 pixel

            //// Bắt đầu Timer
            //zoom.Start();
        }

        private void btnHam_MouseLeave(object sender, EventArgs e)
        {
            //zoom.Stop();
            //btnHam.Width = btnHam.MinimumSize.Width;
            //btnHam.Height = btnHam.MinimumSize.Height;
            //isZoomed = false;
        }

        private void btnHam_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panelMainContent_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //Mở form hien thi staff
            StaffRepository m_Staff = new StaffRepository();
            if (InitClasses.AddNewStaff.IsDisposed) {
                InitClasses.AddNewStaff = new AddNewStaff();
            }
            AddStaffPresenter p_Staff = new AddStaffPresenter(m_Staff,InitClasses.AddNewStaff);

            InitClasses.AddNewStaff.Show();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            StaffRepository m_Staff = new StaffRepository();
            
            StaffPresenter p_Staff = new StaffPresenter(InitClasses.staffView, m_Staff);


            ShowFormInPanel(InitClasses.staffView);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }




    }
}
