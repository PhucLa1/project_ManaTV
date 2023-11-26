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
    public partial class BillOverall : Form
    {
        //0 : Sale Bill, 1 : Import Bill
        private string screen, design, color;
        private float size;
        private BillRepository bR = new BillRepository();
        public BillOverall(int status)
        {
            InitializeComponent();
        }

        private void BillOverall_Load(object sender, EventArgs e)
        {
            //Init variable
            InitVariable();

            //Init Datagridview 
            //4 đối số để filter : screen,size,desgin,color
            InitDataGridView();

            //Init for dropdown
            InitScreen();
            InitSize();
            InitColor();
            InitDesigns();
        }

        private void InitDataGridView()
        {
            ProductDGV.Rows.Clear();
            var result = bR.GetFilterProduct(screen, size, design, color);
            foreach(var item in result)
            {
                ProductDGV.Rows.Add(new object[]
                {
                    item["id"].ToString(),
                    $"Tivi {item["manufacturer_name"].ToString()} " +
                    $"{item["screen_name"].ToString()} " +
                    $"{item["screen_size"].ToString()} " +
                    $"{item["design_name"].ToString()}"
                });
            }
        }

        private void InitVariable()
        {
            screen = ""; size = -1; design = ""; color = "";
        }

        private void InitDesigns()
        {
            List<string> designsDD = bR.GetAllDesign();
            foreach (var design in designsDD)
            {
                DesignDD.Items.Add(design);
            }
        }

        private void InitColor()
        {
            List<string> colorsDD = bR.GetAllColor();
            foreach (var color in colorsDD)
            {
                ColorDD.Items.Add(color);
            }
        }

        private void InitSize()
        {
            List<string> sizeDD = bR.GetAllSize();
            foreach (var size in sizeDD)
            {
                SizeDD.Items.Add(size);
            }
        }

        private void InitScreen()
        {
            List<string> screenDD = bR.GetAllScreen();
            foreach (var screen in screenDD)
            {
                ScreenDD.Items.Add(screen);
            }
        }

        private void screenDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            screen = ScreenDD.Text;
            InitDataGridView();
        }

        private void DesignDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            design = DesignDD.Text;
            InitDataGridView();
        }

        private void SizeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = float.Parse(SizeDD.Text);
            InitDataGridView();
        }

        private void ColorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = ColorDD.Text;
            InitDataGridView();
        }
    }
}
