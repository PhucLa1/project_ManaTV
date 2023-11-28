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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_ManaTV.Views.Components
{
    public partial class Product : UserControl
    {
        private BillRepository bR = new BillRepository();
        private int imageIndex = 0;
        private int maxIndex; 
        private List<string> imagePaths;
        public int i;

        public event EventHandler DataChanged;
        public event EventHandler DisposeChange;
        //Cac bien static 
        public int numberProduct
        {
            get { return (int)productNumber.Value; }
            set { productNumber.Value = value; }
        }

        public int priceProduct
        {
            get { return int.Parse(priceTxt.Text); }
            set { priceTxt.Text = value.ToString(); }
        }



        public Product(int _i)
        {
            //I ở đây là mã sản phẩm
            InitializeComponent();
            i = _i;

            

        }

        private void ImageProduct_Tick(object sender, EventArgs e)
        {
            if(maxIndex != 0)
            {
                imageIndex++;
                if (imageIndex >= imagePaths.Count)
                {
                    imageIndex = 0;
                }
                pictureBox1.Image = HandleImage.filePath("Products", imagePaths[imageIndex]);
            }                   
        }

        private void Product_Load(object sender, EventArgs e)
        {
            //Phần ảnh
            maxIndex = bR.GetImageByProductID(i).Count();
            imagePaths = bR.GetImageByProductID(i);
            if(maxIndex != 0)
            {
                pictureBox1.Image = HandleImage.filePath("Products", imagePaths[imageIndex]);
            }

            //Phần sản phẩm
            var product = bR.GetProductByID(i);
            productLb.Text = $"Tivi {product["manufacturer_name"].ToString()} " +
                $"{product["manufacturer_name"].ToString()} " +
                $"{product["screen_name"].ToString()} " +
                $"{product["screen_size"].ToString()} " +
                $"{product["design_name"].ToString()} ";

            //Phan so luong
            productNumber.Value = 1;

            //Phần giá nhập
            priceTxt.Text = product["product_import_money"].ToString();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            DisposeChange?.Invoke(this, EventArgs.Empty);
            //this.Dispose();

        }

        private int previousValue = 1;
        private void productNumber_ValueChanged(object sender, EventArgs e)
        {
            if (productNumber.Value == 0)
            {
                // Nếu giá trị mới là 0, hãy đặt lại giá trị trước đó
                productNumber.Value = previousValue;
            }
            else
            {
                // Nếu giá trị không phải 0, lưu giá trị mới vào biến previousValue và gửi sự kiện DataChanged
                previousValue = (int)productNumber.Value;
                DataChanged?.Invoke(this, EventArgs.Empty);
            }
        }




        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
