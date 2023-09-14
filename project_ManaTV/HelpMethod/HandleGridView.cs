using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.HelpMethod
{
    internal class HandleGridView
    {
        public static void SetMiddleCenter(int countCol, BunifuDataGridView gridView)
        {
            for (int i = 0; i < countCol; i++)
            {
                gridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
