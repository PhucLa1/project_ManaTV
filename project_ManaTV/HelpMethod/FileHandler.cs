using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.HelpMethod
{
    public static class FileHandler
    {
        public static void ExportToExcel(DataGridView dataGridView1, string filename, string sheetTile)
        {
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


                worksheet.get_Range("D1:J1").Merge();
                worksheet.get_Range("D1").Value = sheetTile;
                worksheet.get_Range("D1").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount - 3; i++)
                {
                    worksheet.Cells[4, i + 4] = dataGridView1.Columns[i].HeaderText;
                    worksheet.Cells[4, i + 4].Font.color = Color.Blue;
                    worksheet.Cells[4, i + 4].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount - 3; j++)
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

        public static void ExportReport(string filename, List<Dictionary<string, object>> lst, string titile)
        {

            ICollection<string> keys = lst[0].Keys;

            PdfPTable pdfTable = new PdfPTable(keys.Count);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 100;

            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

            foreach (var key in keys)
            {
                PdfPCell cell = new PdfPCell(new Phrase(key));
                cell.Padding = 10;
                cell.BackgroundColor = BaseColor.DARK_GRAY;
                cell.Phrase.Font.Color = BaseColor.WHITE;
                pdfTable.AddCell(cell);
            }

            foreach (var item in lst)
            {
                foreach (var key in keys)
                {

                    pdfTable.AddCell(item[key].ToString());
                }
            }

            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                Chunk c1 = new Chunk(titile);
                pdfDoc.Add(c1);
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("Data Exported Successfully !!!", "Info");
        }


        public static void ExportReport2(string filename, List<object> lst, string titile)
        {

            HashSet<string> keys = new HashSet<string>();
            foreach (object obj in lst)
            {
                PropertyInfo[] properties = obj.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    keys.Add(property.Name);
                }
            }

            PdfPTable pdfTable = new PdfPTable(keys.Count);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 100;

            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

            foreach (var key in keys)
            {
                PdfPCell cell = new PdfPCell(new Phrase(key));
                cell.Padding = 10;
                cell.BackgroundColor = BaseColor.DARK_GRAY;
                cell.Phrase.Font.Color = BaseColor.WHITE;
                pdfTable.AddCell(cell);
            }

            foreach (var item in lst)
            {
                foreach (var key in keys)
                {

                    PropertyInfo property = item.GetType().GetProperty(key);
                    object value = property.GetValue(item);
                    pdfTable.AddCell(value.ToString());
                }
            }

            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                Chunk c1 = new Chunk(titile);
                pdfDoc.Add(c1);
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("Data Exported Successfully !!!", "Info");
        }
    }
}
