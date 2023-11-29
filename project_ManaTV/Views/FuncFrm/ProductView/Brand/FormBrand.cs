using Bunifu.UI.WinForms;
using project_ManaTV.HelpMethod;
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

namespace project_ManaTV.Views.FuncFrm.BrandView
{
    public partial class FormBrand : Form
    {
        private string mode = "";
        private Brand _brand;
        private BrandPresenter _objectPresenter;

        public event EventHandler AfterClick;
        public FormBrand(string mode, BrandPresenter brandPresenter = null)
        {
            this.mode = mode;
            _objectPresenter = brandPresenter;
            
            InitializeComponent();
            pLine.Height = 5;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBrand_Load(object sender, EventArgs e)
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
            var formName = mode[0].ToString().ToUpper() +mode.Substring(1) + " " + "Brand";
            this.Text = formName;
            lblFormName.Text = formName;

        }


        //FORM GET SET ACTION
        public void SetData(Brand brand)
        {
            _brand = brand;
            txtId.Text = brand.Id.ToString();
            txtName.Text = brand.Name;
            txtAddress.Text = brand.Address;

        }
        private Brand GetData()
        {
            return new Brand
            {
                Id = txtId.Text == "" ? 0 : int.Parse(txtId.Text),
                Name = txtName.Text,
                Address = txtAddress.Text
            };
        }

        private bool IsValid(Brand data)
        {
            string message = "";
            if (data.Name == "")
            {
                message = "Name is required!";
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
                SetData(_brand);
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
            }
            
        }
        private void SetFormStatus(bool status)
        {
            txtId.ReadOnly = !status;
            txtName.ReadOnly = !status;
            txtAddress.ReadOnly = !status;
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
