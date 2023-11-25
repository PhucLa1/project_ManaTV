using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Views.Components;
using project_ManaTV.Views.FuncFrm.BrandView;
using project_ManaTV.Views.FuncFrm.ColorView;
using project_ManaTV.Views.FuncFrm.OriginView;
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
            tabProductList.BackColor = System.Drawing.Color.White;
            tabBrand.BackColor = System.Drawing.Color.White;
            tabColor.BackColor = System.Drawing.Color.White;
            tabDesign.BackColor = System.Drawing.Color.White;
            tabOrigin.BackColor = System.Drawing.Color.White;
            tabScreen.BackColor = System.Drawing.Color.White;
            tabScreenSize.BackColor = System.Drawing.Color.White;
            tabTrash.BackColor = System.Drawing.Color.White;
            this.Padding = new Padding(0, 10, 0, 0);

        }
        public void ShowTab(string tabName)
        {
            if (tabName == "brand") wrapperProduct.SelectedTab = tabBrand;
            else if (tabName == "color") wrapperProduct.SelectedTab = tabColor;
            else if (tabName == "origin") wrapperProduct.SelectedTab = tabOrigin;
            else if (tabName == "design") wrapperProduct.SelectedTab = tabDesign;
            else if (tabName == "screen") wrapperProduct.SelectedTab = tabScreen;
            else if (tabName == "screenSize") wrapperProduct.SelectedTab = tabScreenSize;
            else if (tabName == "product") wrapperProduct.SelectedTab = tabProductList;
            else if (tabName == "trash") wrapperProduct.SelectedTab = tabTrash;
        }
        public void ShowFormInPanel_Product(Form formToShow)
        {
            panelProducts.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelProducts.Controls.Add(formToShow);
            panelProducts.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelProducts.Size;
            };
            formToShow.Show();

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
        public void ShowFormInPanel_Color(Form formToShow)
        {
            panelColor.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelColor.Controls.Add(formToShow);
            panelColor.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelColor.Size;
            };
            formToShow.Show();
        }
        public void ShowFormInPanel_Origin(Form formToShow)
        {
            panelOrigin.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelOrigin.Controls.Add(formToShow);
            panelOrigin.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelOrigin.Size;
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

        public void ShowFormInPanel_Trash(Form formToShow)
        {
            panelTrash.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelTrash.Controls.Add(formToShow);
            panelTrash.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelTrash.Size;
            };
            formToShow.Show();
        }

        //Change Tab
        private void wrapperProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (wrapperProduct.SelectedIndex)
            {
                case 0:
                    {
                        var lstProduct = new FrmListProducts();
                        lstProduct.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Product(lstProduct);
                        break;
                    }
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
                case 3:
                    {
                        var lstColor = new FrmListColors();
                        lstColor.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Color(lstColor);
                        break;
                    }
                case 6:
                    {
                        var lstOrigin = new FrmListOrigins();
                        lstOrigin.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Origin(lstOrigin);
                        break;
                    }
                case 7:
                    {
                        var lstTrash = new FrmTrashListProducts();
                        lstTrash.FRM_LAYOUT = this.FRM_LAYOUT;
                        ShowFormInPanel_Trash(lstTrash);
                        break;
                    }
            }
        }
    }
}
