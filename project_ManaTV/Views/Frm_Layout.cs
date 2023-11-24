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

using project_ManaTV.Views.FuncFrm.CustomerView;
using project_ManaTV.Views.FuncFrm.BrandView;
using project_ManaTV.Views.FuncFrm.ProductView;
using Bunifu.UI.WinForms;

namespace project_ManaTV
{


    //Sẽ lấy hết tất cả ở đây

    public partial class Frm_Layout : Form
    {
        FontFamily[] fontFamilies;
        private ProductPanel productPanel;
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
            sidebar.Width = 244;
            //panelMainContent.BackgroundColor = ColorTranslator.FromHtml("#29374B");
            panelMainContent.Dock = DockStyle.Fill;

            var lstMenuButtons = new List<BunifuButton>() { btnDashboard , btnLogOut , btnProduct , btnStaff, btnCustomerWrapper, btnInvoice };
            foreach (var btn in lstMenuButtons)
            {
                CustomMenuButton(btn);
            }

            var lstWrapperPanel = new List<FlowLayoutPanel>() { productSideBar, staffSideBar, fLayoutCustommer };
            foreach (var wrapper in lstWrapperPanel)
            {
                CustomWrapperPanel(wrapper);
            }

        }
        private void CustomMenuButton(BunifuButton menuButton)
        {
            menuButton.Height = 48;
            menuButton.IdleFillColor = ColorTranslator.FromHtml("#29374B");
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

        private void CustomWrapperPanel(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Height = btnDashboard.Height;
            flowLayoutPanel.BackColor = Color.FromArgb(40, 96, 144);
            bool isFirst = true;
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is BunifuButton button)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        continue;
                    }
                    control.Height = 40;
                    control.Font = new Font(control.Font.FontFamily, 10, control.Font.Style);

                }
                
            }
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panelMainContent.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            //formToShow.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(formToShow);

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
                if (productSideBar.Height >= 384)
                {
                    productExpand = true;
                    productTrans.Stop();
                }
            }
            else
            {
                productSideBar.Height -= 10;
                if (productSideBar.Height <= 48)
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
                if (staffSideBar.Height >= 130)
                {
                    staffExpand = true;
                    staffTrans.Stop();
                }
            }
            else
            {
                staffSideBar.Height -= 10;
                if (staffSideBar.Height <= 48)
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
                if (sidebar.Width >= 244)
                {
                    sidebarExpand = true;
                    sidebarTrans.Stop();
                    setButtonWidth();

                }
            }
            else
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 54)
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
            productPanel = new ProductPanel();
            productPanel.FRM_LAYOUT = this;
            ShowFormInPanel(productPanel);
            //productPanel.ShowTab("brand");
            //productPanel.ShowFormInPanel_Brand(lstBrand);
            productPanel.Size = panelMainContent.Size;
            panelMainContent.SizeChanged += (s, ev) =>
            {
                productPanel.Size = panelMainContent.Size;
            };
        }


        private bool isZoomed = false;
        private int targetWidth;
        private int targetHeight;


        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //Mở form hien thi staff
            StaffRepository m_Staff = new StaffRepository();
            if (InitClasses.AddNewStaff == null || InitClasses.AddNewStaff.IsDisposed) {
                InitClasses.AddNewStaff = new AboutStaff(-1,"Add");
            }
            AboutStaffPresenter p_Staff = new AboutStaffPresenter(m_Staff,InitClasses.AddNewStaff);

            InitClasses.AddNewStaff.Show();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            StaffRepository m_Staff = new StaffRepository();
            
            StaffPresenter p_Staff = new StaffPresenter(InitClasses.staffView, m_Staff);


            ShowFormInPanel(InitClasses.staffView);
        }



        //CUSTOMER SIDE BAR
        private void btnCustomerWrapper_Click(object sender, EventArgs e)
        {
            customerTrans.Start();
            
        }

        private bool customerExpand = false;
        private void customerTrans_Tick(object sender, EventArgs e)
        {
            if (customerExpand == false)
            {
                fLayoutCustommer.Height += 10;
                if (fLayoutCustommer.Height >= 130)
                {
                    customerExpand = true;
                    customerTrans.Stop();
                }
            }
            else
            {
                fLayoutCustommer.Height -= 10;
                if (fLayoutCustommer.Height <= 48)
                {
                    customerExpand = false;
                    customerTrans.Stop();
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            var lstCustomerForm = new ListCustomers();
            ShowFormInPanel(lstCustomerForm);
            lstCustomerForm.Size = panelMainContent.Size;
            lstCustomerForm.tab = panelMainContent.Size;
            lstCustomerForm.gridView = new Size(lstCustomerForm.tab.Width, lstCustomerForm.gridView.Height);
            panelMainContent.SizeChanged += (s, ev) =>
            {
                //MessageBox.Show("ok");
                lstCustomerForm.Size = panelMainContent.Size;
                lstCustomerForm.tab = panelMainContent.Size;
                lstCustomerForm.gridView = new Size(lstCustomerForm.tab.Width, lstCustomerForm.gridView.Height);
            };
        }

        private void btnTrashCustomer_Click(object sender, EventArgs e)
        {
            var lstCustomerForm = new ListCustomers();
            lstCustomerForm.ShowTabTrash();
            ShowFormInPanel(lstCustomerForm);
            lstCustomerForm.Size = panelMainContent.Size;
            lstCustomerForm.tab = panelMainContent.Size;
            lstCustomerForm.gridView = new Size(lstCustomerForm.tab.Width, lstCustomerForm.gridView.Height);
            panelMainContent.SizeChanged += (s, ev) =>
            {
                //MessageBox.Show("ok");
                lstCustomerForm.Size = panelMainContent.Size;
                lstCustomerForm.tab = panelMainContent.Size;
                lstCustomerForm.gridView = new Size(lstCustomerForm.tab.Width, lstCustomerForm.gridView.Height);
            };
            
        }


        //PRODUCT
        private void btnAllProduct_Click(object sender, EventArgs e)
        {

        }
        private void btnBrand_Click(object sender, EventArgs e)
        {

            var lstBrand = new FrmListBrands();
            lstBrand.FRM_LAYOUT = this;
            productPanel.ShowTab("brand");
            productPanel.ShowFormInPanel_Brand(lstBrand);
 
            //var lstBrand = new FrmListBrands();
            //lstBrand.FRM_LAYOUT = this;
            //var productPanel = new ProductPanel();
            //ShowFormInPanel(productPanel);
            //productPanel.ShowTab("brand");
            //productPanel.ShowFormInPanel_Brand(lstBrand);
            //productPanel.Size = panelMainContent.Size;
            //panelMainContent.SizeChanged += (s, ev) =>
            //{
            //    productPanel.Size = panelMainContent.Size;
            //};

        }
        private void btnDesign_Click(object sender, EventArgs e)
        {
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        private void btnScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnScreenSize_Click(object sender, EventArgs e)
        {

        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {

        }

        private void btnTrashProduct_Click(object sender, EventArgs e)
        {

        }

 

    }
}
