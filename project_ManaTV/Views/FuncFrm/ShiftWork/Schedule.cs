using Bunifu.UI.WinForms;
using project_ManaTV.HelpMethod;
using project_ManaTV.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.ShiftWork
{
    public partial class Schedule : Form
    {
        private int i;
        private ShiftWorkRespository db = new ShiftWorkRespository();
        private List<int> schedule;
        public Schedule(int _i)
        {
            i = _i;
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            //Setup header color
            Color alterHeaderColor = Color.FromArgb(40, 96, 144);
            shiftWorkDGV.ColumnHeadersDefaultCellStyle.BackColor = alterHeaderColor;
            shiftWorkDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            shiftWorkDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = alterHeaderColor;
            shiftWorkDGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //Setup Row Color
            Color alterRowColor = Color.FromArgb(224, 224, 224);
            shiftWorkDGV.AlternatingRowsDefaultCellStyle.BackColor = alterRowColor;
            shiftWorkDGV.AlternatingRowsDefaultCellStyle.ForeColor = Color.Empty;
            shiftWorkDGV.AlternatingRowsDefaultCellStyle.SelectionBackColor = alterRowColor;
            shiftWorkDGV.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Empty;
            //Setup Cell Color
            Color alterFontColor = Color.FromArgb(64, 64, 64);
            shiftWorkDGV.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            shiftWorkDGV.DefaultCellStyle.ForeColor = alterFontColor;
            shiftWorkDGV.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            shiftWorkDGV.DefaultCellStyle.SelectionForeColor = alterHeaderColor;
            InitDGV();
        }

        private void InitDGV()
        {
            shiftWorkDGV.Rows.Clear();

            var res = db.GetEmployeeById(i);

            //Lay ra cac ca lam viec
            string shiftwork = res["shiftwork"] == null ? "0" : res["shiftwork"].ToString();

            string[] arrayShiftWork = shiftwork.Split(',');
            int[] arrayShiftWorkInt = Array.ConvertAll(arrayShiftWork, int.Parse);
            schedule = new List<int>(arrayShiftWorkInt);
            schedule.Sort();

            shiftWorkDGV.Rows.Add("Morning Shift");
            shiftWorkDGV.Rows.Add("Afternoon Shift");
            shiftWorkDGV.Rows.Add("Evening Shift");

            Image work = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "CheckMark.png"));
            Image notWork = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "Cross.png"));
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                shiftWorkDGV.Rows[i].Height = 144;
                for(int j = 1;j <= 7; j++)
                {
                    if(i*7 + j == schedule[k])
                    {
                        k++;
                        shiftWorkDGV.Rows[i].Cells[j].Value = work;
                    }
                    else
                    {
                        shiftWorkDGV.Rows[i].Cells[j].Value = notWork;
                    }
                    if(k >= schedule.Count())
                    {
                        k = 0;
                    }
                }
            }
            lbStaff.Text = "Name of Staff : "+res["staff_name"].ToString();
        }

        private void shiftWorkDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Image work = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "CheckMark.png"));
                Image notWork = HandleImage.ZoomOutImage(HandleImage.filePath("assets/icons", "Cross.png"));
                //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString()); 
                int idSchedule = e.RowIndex * 7 + e.ColumnIndex;
                if (schedule.Contains(idSchedule))
                {
                    schedule.Remove(idSchedule);
                    shiftWorkDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = notWork;
                }
                else
                {
                    schedule.Add(idSchedule);
                    shiftWorkDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = work;
                }
            }
        }

        private void ShowMessage(string message, BunifuSnackbar.MessageTypes messageTypes)
        {

            Message.Show(this, message,
            messageTypes,
            1000,
            "",
            BunifuSnackbar.Positions.TopRight);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(schedule.Count() < 5) 
            {
                ShowMessage("Must do at least 5 days within the week", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                schedule.Sort();
                if (schedule.Contains(0))
                {
                    schedule.Remove(0);
                }
                string shiftwork = string.Join(",", schedule);
                db.UpdateEmployee(shiftwork, i);
                ShowMessage("Save schedule successfully", BunifuSnackbar.MessageTypes.Success);
                this.Dispose();
            }
        }


    }
}
