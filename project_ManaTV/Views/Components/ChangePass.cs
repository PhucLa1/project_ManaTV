using project_ManaTV.Views.FuncFrm.Login;
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
    public partial class ChangePass : Form
    {
        public event EventHandler continueClick;
        public string text;
        public string label;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            lbText.Text = "Enter the username you want to find the password";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            text = txtText.Text;
            continueClick?.Invoke(this, EventArgs.Empty);
            lbPass.Text = Login.Pass;
            
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
