using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Views.Components;
using project_ManaTV.Views.FuncFrm.BrandView;
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
            else if (tabName == "design") wrapperProduct.SelectedTab = tabDesign;
            else if (tabName == "product") wrapperProduct.SelectedTab = tabProductList;
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

        public void ShowFormInPanel_Product(Form formToShow)
        {
            panelProduct.Controls.Clear();

            // Hiển thị form con trong Panel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panelProduct.Controls.Add(formToShow);
            panelProduct.SizeChanged += (s, ev) =>
            {
                formToShow.Size = panelProduct.Size;
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

                        break;
                    }
            }
        }
    }
}
