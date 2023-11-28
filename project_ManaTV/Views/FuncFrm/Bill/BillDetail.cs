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

namespace project_ManaTV.Views.FuncFrm.Bill
{
    public partial class BillDetail : Form
    {
        //1 là nhập, 0 là bán
        //status : Nhập hoặc bán, i là id bill
        private int i;
        private BillRepository bR = new BillRepository();
        public BillDetail(int status, int _i)
        {
            i = _i;
            InitializeComponent();
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            var billDetails = bR.GetDetailBillByBillID(i);
            foreach(var bill in billDetails)
            {
                detailBill.Rows.Add(new object[]
                {
                    bill["id"].ToString(),
                    bill["Product ID"].ToString(),
                    bill["price"].ToString(),
                    bill["import_amount"].ToString()
                });
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
