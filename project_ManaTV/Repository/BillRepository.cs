using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Repository
{
    public class BillRepository
    {
        Database db = new Database();

        public List<Dictionary<string, object>> GetFilterProduct(string screen, float size, string design, string color)
        {
            string design_status = "1=1";
            string color_status = "1=1";
            string screen_status = "1=1";
            string size_status = "1=1";

            // Câu lệnh truy vấn

            
            if(screen != "") { screen_status = $"screen_name = '{screen}'";  }
            if(size > 1) { size_status = $"screen_size = '{size}'"; }
            if(design != "") { design_status = $"design_name = '{design}'"; }
            if(color != "") { color_status = $"color_name = '{color}'"; }

            string query = $"select " +
    $"Products.id,product_amount,product_import_money,product_sell_money," +
    $"design_name,manufacturer_name,color_name,screen_name,screen_size from Products " +
    $"inner join Designs on Products.design_id = Designs.id " +
    $"inner join Manufacturer on Manufacturer.id = Products.manufacturer_id " +
    $"inner join Colors on Colors.id = Products.color_id " +
    $"inner join Screen on Screen.id = Products.screen_id " +
    $"inner join ScreenSize on ScreenSize.id = Products.size_id " +
    $"where {design_status} and {color_status} and {screen_status} and {size_status}";
            //Chạy truy vấn
            db.SetQuery(query);
            
            return db.LoadAllRows();
        }

        //Init for drop down

        public List<string> GetAllScreen()
        {
            string query = "select screen_name from Screen";
            db.SetQuery(query);
            List<string> result = db.LoadAllRows().Select(e => e["screen_name"].ToString()).ToList();
            return result;
        }
        public List<string> GetAllSize()
        {
            string query = "select screen_size from ScreenSize";
            db.SetQuery(query);
            List<string> result = db.LoadAllRows().Select(e => e["screen_size"].ToString()).ToList();
            return result;
        }
        public List<string> GetAllDesign()
        {
            string query = "select design_name from Designs";
            db.SetQuery(query);
            List<string> result = db.LoadAllRows().Select(e => e["design_name"].ToString()).ToList();
            return result;
        }
        public List<string> GetAllColor()
        {
            string query = "select color_name from Colors";
            db.SetQuery(query);
            List<string> result = db.LoadAllRows().Select(e => e["color_name"].ToString()).ToList();
            return result;
        }
    }
}
