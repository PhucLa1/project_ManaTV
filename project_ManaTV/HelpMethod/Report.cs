using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Pkcs;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using project_ManaTV.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;


namespace project_ManaTV.HelpMethod
{
    public class Report
    {
        public Report(string filename , List<Dictionary<string,object>> lst , string titile) {

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
               
                    pdfTable.AddCell(item[key].ToString() );
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
