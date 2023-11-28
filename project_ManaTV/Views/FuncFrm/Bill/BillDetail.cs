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
        private int status;
        private BillRepository bR = new BillRepository();
        public BillDetail(int _status, int _i)
        {
            status = _status;
            i = _i;
            InitializeComponent();
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            if(status == 0)
            {
                lbTitle.Text = "Sell Bill Detail";
            }
            

            var billDetails = bR.GetDetailBillByBillID(status,i);
            string amount = status == 0 ? "sell_amount" : "import_amount";
            foreach (var bill in billDetails)
            {
                detailBill.Rows.Add(new object[]
                {
                    bill["id"].ToString(),
                    bill["Product ID"].ToString(),
                    bill["price"].ToString(),
                    bill[amount].ToString()
                });
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
