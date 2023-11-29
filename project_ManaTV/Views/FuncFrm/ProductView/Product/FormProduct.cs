using Bunifu.UI.WinForms;
using project_ManaTV.HelpMethod;
using project_ManaTV.Models;
using project_ManaTV.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //Brand
            var dataSourceBrand = _objectPresenter.GetAllBrand();
            dataSourceBrand.Add(new Brand() { Id = 0, Name = "No Brand" });
            cbManu.DataSource = dataSourceBrand;
            cbManu.DisplayMember = "Name";
            cbManu.ValueMember = "Id";
            cbManu.SelectedValue = 0;

            //Color
            var dataSourceColor = _objectPresenter.GetAllColor();
            dataSourceColor.Add(new Colors() { Id = 0, color_name = "No Color" });
            cbColor.DataSource = dataSourceColor;
            cbColor.DisplayMember = "color_name";
            cbColor.ValueMember = "Id";
            cbColor.SelectedValue = 0;

            //Design
            var dataSourceDesign = _objectPresenter.GetAllDesign();
            dataSourceDesign.Add(new Design() { Id = 0, Name = "No Design" });
            cbDesign.DataSource = dataSourceDesign;
            cbDesign.DisplayMember = "Name";
            cbDesign.ValueMember = "Id";
            cbDesign.SelectedValue = 0;


            //Origin
            var dataSourceOrigin = _objectPresenter.GetAllOrigin();
            dataSourceOrigin.Add(new Origin() { Id = 0, Name = "No Origin" });
            cbCountry.DataSource = dataSourceOrigin;
            cbCountry.DisplayMember = "Name";
            cbCountry.ValueMember = "Id";
            cbCountry.SelectedValue = 0;


            //Screen
            var dataSourceScreen = _objectPresenter.GetAllScreen();
            dataSourceScreen.Add(new Models.Screen() { Id = 0, Name = "No Screen" });
            cbScreen.DataSource = dataSourceScreen;
            cbScreen.DisplayMember = "Name";
            cbScreen.ValueMember = "Id";
            cbScreen.SelectedValue = 0;


            //ScreenSize
            var dataSourceScreenSize = _objectPresenter.GetAllScreenSize();
            dataSourceScreenSize.Add(new ScreenSize() { Id = 0, Screen_size = 0 });
            cbSize.DataSource = dataSourceScreenSize;
            cbSize.DisplayMember = "Screen_size";
            cbSize.ValueMember = "Id";
            cbSize.SelectedValue = 0;


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
                btnUpload.Visible = false;
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
            cbColor.SelectedValue = product.ColorId;
            cbCountry.SelectedValue = product.CountryId;
            cbDesign.SelectedValue = product.DesignId;
            cbScreen.SelectedValue = product.ScreenId;
            cbSize.SelectedValue = product.SizeId;

            //Images
            var lstImages = _objectPresenter.GetAllImages(product.Id);
            string startupPath = Application.StartupPath;
            string grandParentDirectory = Path.GetDirectoryName(Path.GetDirectoryName(startupPath));
            string imagesFolderPath = Path.Combine(grandParentDirectory, "wwwroot" + "\\Products\\Virtual");

            var lstPathImage = new List<string>();
            foreach (var imgName in lstImages)
            {
                lstPathImage.Add(Path.Combine(imagesFolderPath, imgName));
            }
            if(lstPathImage.Count > 0) GenerateListImages(lstPathImage);



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
                ProductImportMoney = txtImportedAmount.Text == "" ? 0 : int.Parse(txtImportedAmount.Text),
                ProductSellMoney = txtPrice.Text == "" ? 0 : int.Parse(txtPrice.Text)
            };
        }

        private void UpdateListImage(int productId)
        {
            var res = new List<string>();
            var lstImage = new List<PictureBox>();
            foreach (PictureBox pic in fplImages.Controls)
            {
                if (pic.Image != null)
                {
                    res.Add(pic.Tag.ToString());
                    lstImage.Add(pic);
                }
            }
            try
            {
                _objectPresenter.UpdateProductImage(productId, res);
                foreach (var item in lstImage)
                {
                    HandleImage.UploadImage(item.Image,"\\Products\\Virtual", item.Tag.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            
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
            foreach (PictureBox pic in fplImages.Controls)
            {
                pic.Enabled = status;
            }

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
                var newObjId = _objectPresenter.GetAll().LastOrDefault().Id;
                UpdateListImage(newObjId);
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
                UpdateListImage(data.Id);
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
            var manu = cbManu.Text != "No Brand" ? cbManu.Text : "";
            var design = cbDesign.Text != "No Design" ? cbDesign.Text : "";
            var screen = cbScreen.Text != "No Screen" ? cbScreen.Text : "";
            var tvName = manu + " " + design + " " + screen;
            return tvName;
        }

        public void ShowToast(string message, BunifuSnackbar.MessageTypes messageTypes)
        {
            snackBarForm.Show(this, message,
                messageTypes,
                1000,
                "",
                BunifuSnackbar.Positions.TopRight);
        }

        public PictureBox GeneratePictureBox(string fileName)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(fileName);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Height = fplImages.Height - 30;
            pictureBox.Width = fplImages.Height - 30;
            pictureBox.Tag = Path.GetFileName(fileName);
            return pictureBox;
        }

        public void GenerateListImages(List<string> lstFilePath)
        {
            fplImages.Controls.Clear();
            foreach (var fileName in lstFilePath)
            {
                var pictureBox = GeneratePictureBox(fileName);
                //pictureBox.Margin = 
                fplImages.Controls.Add(pictureBox);
                pictureBox.DoubleClick += (e, v) =>
                {
                    var deleteBox = MessageBox.Show("Do you really want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deleteBox == DialogResult.Yes)
                    {
                        fplImages.Controls.Remove(pictureBox);
                        pictureBox.Image.Dispose();
                        pictureBox.Dispose();
                    }

                };

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                GenerateListImages(openFileDialog.FileNames.ToList());
            }
        }
    }
}
