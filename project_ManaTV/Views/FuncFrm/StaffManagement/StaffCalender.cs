using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Views.FuncFrm.StaffManagement
{
    public partial class StaffCalender : Form
    {
        //Xử lí chọn ngày làm việc cho chính mình
        //Chỉ được chọn trong tháng hoặc chọn cho tháng tới nếu còn cách tháng tới tầm 4,5 ngày thì mới được chọn 
        //lịch làm cho tháng mới(Lưu ý được chọn nhiều nhất là 6 hoặc 7 ngày liên tiếp không được chọn hơn)
        //Khi nhấn submit nó sẽ được đưa sang bên phần tabpage kia để hiển thị 
        //Phần tabpage để hiển thị sẽ bao gồm là submit(nộp), approved(chấp nhận) , rejected(từ chối) - Bên cạnh cái từ chối sẽ phải có lí do
        //Tiếp theo là phần hiển thị trong ngày làm việc hôm nay ( Hoặc có thể chọn ngày ) ca sáng chiều tối xem có những
        //ai làm việc

        //Mục tiêu xử lí : 
        private bool isStart = false,isEnd = false;
        private DateTime startDate,endDate;
        private List<DateTime> daysBetween = new List<DateTime>();
        public StaffCalender()
        {
            InitializeComponent();
        }

        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            isStart = true;
            startDate = dpStart.Value;
            showSchedule();
        }

        private void dpEnd_ValueChanged(object sender, EventArgs e)
        {
            isEnd = true;
            endDate = dpEnd.Value;
            showSchedule();
        }
        private void showSchedule()
        {
            if (isEnd == true && isStart == true)
            {               
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    dgvCalender.Rows.Add(
                        new object[]
                        {
                            date.ToString("dddd, dd MMMM yyyy"),

                        }
                    );
                }

            }
        }
    }
}
