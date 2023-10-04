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

namespace project_ManaTV.Views.FuncFrm.CustomerView
{
    public partial class FormCustomer : Form
    {
        private string mode = "";
        private Customer _customer;
        private CustomerPresenter _customerPresenter;

        public event EventHandler AfterClick;
        public FormCustomer(string mode, CustomerPresenter customerPresenter = null)
        {
            this.mode = mode;
            _customerPresenter = customerPresenter;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
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
            var formName = mode[0].ToString().ToUpper() +mode.Substring(1) + " " + "Customer";
            this.Text = formName;
            lblFormName.Text = formName;

        }

        public void SetData(Customer customer)
        {
            _customer = customer;
            txtId.Text = customer.Id.ToString();
            txtFullname.Text = customer.FullName;
            txtEmail.Text = customer.Email;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtAddress.Text = customer.Address;

        }
        private void ResetForm()
        {
            if(mode == "update")
            {
                SetData(_customer);
            }
            else
            {
                txtId.Text = "";
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
            }
            
        }

        private Customer GetData()
        {
            
            return new Customer
            {
                Id = txtId.Text == ""?0:int.Parse(txtId.Text),
                FullName = txtFullname.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text
            };
        }

        private void SetFormStatus(bool status)
        {
            txtId.Enabled = status;
            txtFullname.Enabled = status;
            txtEmail.Enabled = status;
            txtPhoneNumber.Enabled = status;
            txtAddress.Enabled = status;
        }
        private void FormCustomer_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = GetData();
            _customerPresenter.AddNew(customer);
            AfterClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = GetData();
            _customerPresenter.Update(customer);
            AfterClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
