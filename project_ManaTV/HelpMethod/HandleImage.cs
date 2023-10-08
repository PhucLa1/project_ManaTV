using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.HelpMethod
{
    internal class HandleImage
    {
        //Hien thi hinh anh len picturebox

        public static Image filePath(string folder,string nameImage)
        {
            string startupPath = Application.StartupPath;
            string grandParentDirectory = Path.GetDirectoryName(Path.GetDirectoryName(startupPath));
            string imagesFolderPath = Path.Combine(grandParentDirectory, "wwwroot/"+folder);


            // Đường dẫn tới tệp hình ảnh cụ thể trong thư mục "images"
            string imagePath = Path.Combine(imagesFolderPath, nameImage); // Thay "your_image.jpg" bằng tên tệp hình ảnh thực tế

            // Kiểm tra xem tệp hình ảnh tồn tại trước khi gán
            if (File.Exists(imagePath))
            {
                // Tạo một đối tượng hình ảnh từ tệp hình ảnh
                Image image = Image.FromFile(imagePath);

                // Gán hình ảnh cho PictureBox
                return image;
            }
            else
            {
                // Xử lý trường hợp tệp hình ảnh không tồn tại
                return null;
            }
        }


        //Mo hop thoai chon hinh anh dong thoi luu hinh anh vào folder wwwroot
        //Kiểm tra nếu chuỗi trả về là "" thì có nghĩa là file chưa được chọn hoặc chưa được lưu


        //Cái open image chỉ trả về một cái generate
        public static string selectedFilePath = "";
        public static void OpenImageAndShow(BunifuPictureBox picBox)
        {           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Chỉ cho phép các loại tệp ảnh phổ biến
            openFileDialog1.Title = "Chọn ảnh";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog1.FileName;
                picBox.Image = new Bitmap(openFileDialog1.FileName);
               
            }
        }

        public static string SaveImage(string folder)
        {
            //File được lưu vào trong folder trong dự án
            string startupPath = Application.StartupPath;
            string grandParentDirectory = Path.GetDirectoryName(Path.GetDirectoryName(startupPath));
            string imagesFolderPath = Path.Combine(grandParentDirectory, "wwwroot/", folder);
            string genName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".png";
            string targetPath = Path.Combine(imagesFolderPath, genName);
            // Kiểm tra nếu thư mục đích không tồn tại thì tạo mới
            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }
            if(selectedFilePath != "")
            {
                File.Copy(selectedFilePath, targetPath, true);
               

            }
            else
            {
                genName = "";
            }            
            return genName;
        }


        public static Image ZoomOutImage(Image originalImage)
        {
            int maxWidth = 20; // Kích thước tối đa bạn muốn hiển thị
            int maxHeight = 20;
            int newWidth, newHeight;

            if (originalImage.Width > maxWidth || originalImage.Height > maxHeight)
            {
                if (originalImage.Width > originalImage.Height)
                {
                    newWidth = maxWidth;
                    newHeight = (int)((float)originalImage.Height / originalImage.Width * maxWidth);
                }
                else
                {
                    newWidth = (int)((float)originalImage.Width / originalImage.Height * maxHeight);
                    newHeight = maxHeight;
                }
            }
            else
            {
                newWidth = originalImage.Width;
                newHeight = originalImage.Height;
            }

            return new Bitmap(originalImage, newWidth, newHeight);
            
        }
    }

}
