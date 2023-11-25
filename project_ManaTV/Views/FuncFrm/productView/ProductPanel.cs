using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Views.Components;
using project_ManaTV.Views.FuncFrm.BrandView;
using project_ManaTV.Views.FuncFrm.DesignView;
using project_ManaTV.Views.FuncFrm.ScreenSizeView;
using project_ManaTV.Views.FuncFrm.ScreenView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.ProductView
{
    public partial class ProductPanel : Form
    {

        public Form FRM_LAYOUT { get; set; }
        public TabControl WrapperProductPanel { get => wrapperProduct;}
        public Panel PanelBrand { get => panelBrand; set=>panelBrand=value; }


        public ProductPanel()
        {
    
            InitializeComponent();
            InitForm();
 
        }

        private void InitForm()
        {
            this.BackColor = ColorTranslator.FromHtml("#29374B");
            tabProductList.BackColor = Color.White;
            tabBrand.BackColor = Color.White;
            tabColor.BackColor = Color.White;
            tabDesign.BackColor = Color.White;
            tabOrigin.BackColor = Color.White;
            tabScreen.BackColor = Color.White;
            tabScreenSize.BackColor = Color.White;
            this.Padding = new Padding(0, 10, 0, 0);

        }
        public void ShowTab(string tabName)
        {
            if (tabName == "brand") wrapperProduct.SelectedTab = tabBrand;
            if (tabName == "design") wrapperProduct.SelectedTab = tabDesign;
            if (tabName == "screen") wrapperProduct.SelectedTab = tabScreen;
            if (tabName == "screenSize") wrapperProduct.SelectedTab = tabScreenSize;
        }

        public void ShowFormInPanel_Brand(Form formToShow)
        {
            panelBrand.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelBrand.Controls.Add(formToShow);
            panelBrand.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelBrand.Size;
            };
            formToShow.Show();

        }
        public void ShowFormInPanel_Design(Form formToShow)
        {
            panelDesign.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelDesign.Controls.Add(formToShow);
            panelDesign.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelDesign.Size;
            };
            formToShow.Show();
        }
        public void ShowFormInPanel_Screen(Form formToShow)
        {
            panelScreen.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelScreen.Controls.Add(formToShow);
            panelScreen.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelScreen.Size;
            };
            formToShow.Show();

        }
        public void ShowFormInPanel_ScreenSize(Form formToShow)
        {
            panelScreenSize.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelScreenSize.Controls.Add(formToShow);
            panelScreenSize.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelScreenSize.Size;
            };
            formToShow.Show();
        }

        //Change Tab
        private void wrapperProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (wrapperProduct.SelectedIndex)
            {
                case 1:
                    {
                        var lstBrand = new FrmListBrands();
                        lstBrand.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Brand(lstBrand);
                        break;
                    }
                case 2:
                    {
                        var lstDesign = new FrmListDesigns();
                        lstDesign.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Design(lstDesign);
                        break;
                    }
                case 4:
                    {
                        var lstScreen = new FrmListScreens();
                        lstScreen.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Screen(lstScreen);
                        break;
                    }
                case 5:
                    {
                        var lstScreenSize = new FrmListScreenSizes();
                        lstScreenSize.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_ScreenSize(lstScreenSize);
                        break;
                    }
            }
        }
    }
}
