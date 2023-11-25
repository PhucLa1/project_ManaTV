using Bunifu.UI.WinForms;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
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
    public partial class FormProduct : Form
    {
        private string mode = "";
        private ProductViewModel _product;
        private ProductPresenter _objectPresenter;

        public event EventHandler AfterClick;
        public FormProduct(string mode, ProductPresenter productPresenter = null)
        {
            this.mode = mode;
            _objectPresenter = productPresenter;
            
            InitializeComponent();
            LoadComboBox();
            
            pLine.Height = 5;
        }

        public void LoadComboBox()
        {
            var dataSource = _objectPresenter.GetAllBrand();
            dataSource.Add(new Brand() { Id = 0, Name = "No Bbrand" });
            cbManu.DataSource = dataSource;
            cbManu.DisplayMember = "Name";
            cbManu.ValueMember = "Id";
            cbManu.SelectedValue = 0;


            //Event
            var lstComboBoxGenerate = new List<ComboBox>() { cbManu, cbDesign, cbScreen };
            foreach (ComboBox cb in lstComboBoxGenerate)
            {
                cb.SelectedIndexChanged += (s,e) =>txtName.Text = GenerateProductName();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            if(mode == "details")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnReset.Visible = false;
                SetFormStatus(false);
            }
            else if(mode == "update")
            {
                btnAdd.Visible = false;
            }
            else if (mode == "add")
            {
                btnUpdate.Visible = false;
            }
            else
            {
                MessageBox.Show("NO ACTION SELECTED");
            }
            var formName = mode[0].ToString().ToUpper() +mode.Substring(1) + " " + "Product";
            this.Text = formName;
            lblFormName.Text = formName;

        }


        //FORM GET SET ACTION
        public void SetData(ProductViewModel product)
        {
            _product = product;
            txtId.Text = product.Id.ToString();
            txtName.Text = product.ManufacturerName + " " + product.DesignName + " " + product.ScreenName;
            txtPrice.Text = product.ProductAmount.ToString();
            txtImportedAmount.Text = product.ProductImportMoney.ToString();

            //SELECT
            cbManu.SelectedValue = product.ManufacturerId;
            


        }
        private Product GetData()
        {
            return new Product
            {
                Id = txtId.Text == "" ? 0 : int.Parse(txtId.Text),
                Name = txtName.Text,
                ManufacturerId = (int)cbManu.SelectedValue,
                ColorId = (int)cbColor.SelectedValue,
                CountryId = (int)cbCountry.SelectedValue,
                DesignId = (int)cbDesign.SelectedValue,
                ScreenId = (int)cbScreen.SelectedValue,
                SizeId = (int)cbSize.SelectedValue,
                ProductAmount = txtPrice.Text == "" ? 0 : int.Parse(txtPrice.Text),
                ProductImportMoney = txtImportedAmount.Text == "" ? 0 : int.Parse(txtImportedAmount.Text)
            };
        }

        private bool IsValid(Product data)
        {
            string message = "";
            if (data.ProductAmount < 0)
            {
                message = " Price is not valid!";
            }
            else if (data.ProductImportMoney < 0)
            {
                message = "Import Money is not valid!";
            }
            if (message != "")
            {
                ShowToast(message, BunifuSnackbar.MessageTypes.Error);
                return false;
            }
            //ShowToast("Validated successfully", BunifuSnackbar.MessageTypes.Success);
            return true;
        }
        private void ResetForm()
        {
            if(mode == "update")
            {
                SetData(_product);
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                cbManu.SelectedValue = 0;
                cbColor.SelectedValue = 0;
                cbCountry.SelectedValue = 0;
                cbDesign.SelectedValue = 0;
                cbScreen.SelectedValue = 0;
                cbSize.SelectedValue = 0;
            }
            
        }
        private void SetFormStatus(bool status)
        {
            txtId.ReadOnly = !status;
            txtName.ReadOnly = !status;
            cbManu.Enabled = status;
            cbColor.Enabled = status;
            cbCountry.Enabled = status;
            cbDesign.Enabled = status;
            cbScreen.Enabled = status;
            cbSize.Enabled = status;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }


        //ADD - UPDATE - VIEW
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var data = GetData();
            if (!IsValid(data)) return;
            try
            {
                _objectPresenter.AddNew(data);
                AfterClick?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception)
            {
                ShowToast("Add failed!!!", BunifuSnackbar.MessageTypes.Error);
                throw;
            }
            
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = GetData();
            if (!IsValid(data)) return;
            try
            {
                _objectPresenter.Update(data);
                AfterClick?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception)
            {
                ShowToast("Update failed!!!", BunifuSnackbar.MessageTypes.Error);
                throw;
            }
            
            this.Close();
        }

        public string GenerateProductName()
        {
            var manu = cbManu.SelectedText != "No brand" ? cbManu.SelectedText : "";
            var design = cbDesign.SelectedText != "No design" ? cbDesign.SelectedText : "";
            var screen = cbScreen.SelectedText != "No screen" ? cbScreen.SelectedText : "";
            return manu + " " + design + " " + screen;
        }

        public void ShowToast(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            snackBarForm.Show(this, message,
                messageTypes,
                1000,
                "",
                BunifuSnackbar.Positions.TopRight);
        }
    }
}
