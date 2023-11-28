using project_ManaTV.HelpMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using project_ManaTV.Presenters;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing;

namespace project_ManaTV.HelpMethod
{
    public class ExportToExcel
    {
        public ExportToExcel(DataGridView dataGridView1,  string filename , string sheetTile) {
                //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
                    Microsoft.Office.Interop.Excel.Application excel;
                    Microsoft.Office.Interop.Excel.Workbook workbook;
                    Microsoft.Office.Interop.Excel.Worksheet worksheet;
                    try
                    {
                        //Tạo đối tượng COM.
                        excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Visible = false;
                        excel.DisplayAlerts = false;
                        //tạo mới một Workbooks bằng phương thức add()
                        workbook = excel.Workbooks.Add(Type.Missing);
                        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet


                    worksheet.get_Range("A1:E1").Merge();
                    worksheet.get_Range("A1").Value = sheetTile;
                    worksheet.get_Range("A1").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount-3; i++)
                        {
                            worksheet.Cells[4, i + 4] = dataGridView1.Columns[i].HeaderText;
                            worksheet.Cells[4, i + 4].Font.color =Color.Blue ;
                            worksheet.Cells[4, i + 4].Borders.LineStyle= Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;




                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount-3; j++)
                            {
                                worksheet.Cells[i + 5, j + 4] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                worksheet.Cells[i + 5, j + 4].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    }
                }
                worksheet.Columns.ColumnWidth = 15; 
                            worksheet.UsedRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


                // sử dụng phương thức SaveAs() để lưu workbook với filename


              
                    workbook.SaveAs(filename);
                    //đóng workbook
                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
                
                
                 }
                        
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook = null;
                    worksheet = null;
                }
        }
    }
}
