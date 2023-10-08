using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.Components
{
    public partial class ConfirmModal : Form
    {
        private string mode = "";
        public ConfirmModal(string mode)
        {
            this.mode = mode;
            InitializeComponent();
            pLine.Height = 5;
        }
        public event EventHandler ConfirmClick;
        private void ConfirmModal_Load(object sender, EventArgs e)
        {
            if(mode == "delete")
            {
                lblHeader.Text = "Confim Delete";
                lblContent.Text = "Do you really want to delete?";
                btnConfirm.Text = "Delete";
                btnConfirm.IdleFillColor =ColorTranslator.FromHtml("#DC4C64");

            }
            lblContent.AutoSize = true;
            lblContent.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
