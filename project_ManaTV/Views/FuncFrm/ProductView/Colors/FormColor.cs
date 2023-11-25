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

namespace project_ManaTV.Views.FuncFrm.ColorView
{
    public partial class FormColor : Form
    {
        private string mode = "";
        private Colors _color;
        private ColorPresenter _objectPresenter;

        public event EventHandler AfterClick;
        public FormColor(string mode, ColorPresenter colorPresenter = null)
        {
            this.mode = mode;
            _objectPresenter = colorPresenter;
            
            InitializeComponent();
            pLine.Height = 5;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormColor_Load(object sender, EventArgs e)
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
            var formName = mode[0].ToString().ToUpper() +mode.Substring(1) + " " + "Color";
            this.Text = formName;
            lblFormName.Text = formName;

        }


        //FORM GET SET ACTION
        public void SetData(Colors color)
        {
            _color = color;
            txtId.Text = color.Id.ToString();
            txtColorName.Text = color.color_name;
            txtR.Text = color.R.ToString();
            txtG.Text = color.G.ToString();
            txtB.Text = color.B.ToString();

        }
        private Colors GetData()
        {
            return new Colors
            {
                Id = txtId.Text == "" ? 0 : int.Parse(txtId.Text),
                R = int.Parse(txtR.Text),
                G = int.Parse(txtG.Text),
                B = int.Parse(txtB.Text),
                color_name = txtColorName.Text
            };
        }

        private bool IsValid(Colors data)
        {
            string message = "";
            if (data.color_name == "")
            {
                message = "Name is required!";
            }
            else if(data.R.ToString() == "")
            {
                message = "R is required!";
            }
            else if (data.G.ToString() == "")
            {
                message = "G is required!";
            }
            else if (data.B.ToString() == "")
            {
                message = "B is required!";
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
                SetData(_color);
            }
            else
            {
                txtId.Text = "";
                txtColorName.Text = "";
                txtR.Text = "";
                txtG.Text = "";
                txtB.Text = "";
            }

        }
        private void SetFormStatus(bool status)
        {
            txtId.ReadOnly = !status;
            txtColorName.ReadOnly = !status;
            txtR.ReadOnly = !status;
            txtG.ReadOnly = !status;
            txtB.ReadOnly = !status;
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

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color c = Color.Black;
            ColorDialog clrDialog = new ColorDialog();

            //show the colour dialog and check that user clicked ok
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                //save the colour that the user chose
                c = clrDialog.Color;
                txtR.Text = c.R.ToString();
                txtG.Text = c.G.ToString();
                txtB.Text = c.B.ToString();

            }
        }
    }
}
