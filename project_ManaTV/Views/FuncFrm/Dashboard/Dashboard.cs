
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.Dashboard
{
    public partial class ListForm : Form
    {
        //Fields

        private Button currentButton;
        private DateTime startDate;
        private DateTime endDate;
        //Constructor
        public ListForm()
        {
            InitializeComponent();
            //Default - Last 7 days
            SetDateMenuButtonsUI(btnLast7Days);

        }
        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;
            //Highlight button
            btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            //Unhighlight button
            if( currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn; //get current button
            if(btn == btnCustomDate)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOkCustomDate.Visible = true;
                lbStartDate.Cursor = Cursors.Hand;
                lbEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                DisableCustomDates();
                lbStartDate.Cursor = Cursors.Default;
                lbEndDate.Cursor = Cursors.Default;
            }

         }

        //Private methods
        private void LoadData()
        {

        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            SetDateMenuButtonsUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {

            SetDateMenuButtonsUI(sender);
        }



        private void lbStartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lbEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {

        }
    }
}
