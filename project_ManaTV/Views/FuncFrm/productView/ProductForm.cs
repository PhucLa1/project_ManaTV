using project_ManaTV.Models;
using project_ManaTV.Presenters;
using project_ManaTV.Presenters.Colors;
using project_ManaTV.Presenters.Designs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = project_ManaTV.Models.Color;

namespace project_ManaTV.Views.FuncFrm.productView
{
    public partial class ProductForm : Form
    {

        private ColorPresenter _colorPresenter;//
        private DesignPresenter designPresenter;
        private Color _color;//
        private Models.Designs _design;
        public event EventHandler AfterClick;//
        private string mode = "";//
        public ProductForm(string method, ColorPresenter colorPresenter = null)
        {
            this.mode = method;
            _colorPresenter = colorPresenter;
            InitializeComponent();
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                btnUpdate.Visible = false;
            }
            if(mode == "details")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnReset.Visible = false;
                txtColorname.Enabled = false;
                txtColorvalue.Enabled = false;
            }
            if(mode == "update")
            {
                btnAdd.Visible=false;
            }
        }
        private Color GetData()//
        {
            return new Color
            {
                Id = txtId.Text == "" ? 0 : int.Parse(txtId.Text),
                Name = txtColorname.Text,
                Value = txtColorvalue.Text
            };
        }

        public void setData<T>(T data)//
        {
            if (data is Color color)
            {
                _color = color;
                txtId.Text = color.Id.ToString();
                txtColorname.Text = color.Name;
                txtColorvalue.Text = color.Value;
            }
            if(data is Designs design)
            {
                _design = design;
                txtId.Text = design.Id.ToString();
                txtColorname.Text = design.Name;
                txtColorvalue.Visible = false;
                label3.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Color color = GetData();//
            _colorPresenter.AddNew(color);
            AfterClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)//
        {
            if (mode == "update")
            {
                setData(_color);
            }
            else
            {
                txtId.Text = "";
                txtColorname.Text = "";
                txtColorvalue.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Color color = GetData();//
            _colorPresenter.Update(color);
            AfterClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
