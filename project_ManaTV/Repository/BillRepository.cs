using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<string> GetAllStaff()
        {
            string query = "select id,staff_name from Staff";
            db.SetQuery(query);
            List<string> result = db.LoadAllRows().Select(e => $"{e["staff_name"].ToString()} : {e["id"].ToString()}").ToList();
            return result;
        }
        public List<string> GetAllSupplier()
        {
            string query = "select id,supplier_name from Supplier";
            db.SetQuery(query);
            List<string> result = db.LoadAllRows().Select(e => $"{e["supplier_name"].ToString()} : {e["id"].ToString()}").ToList();
            return result;
        }
        public List<string> GetImageByProductID(int productID)
        {
            string query = "select * from Images where product_id = @id;";
            db.SetQuery(query);
            return db.LoadAllRows(productID).Select(e => e["image_path"].ToString()).ToList();
        }

        
        public Dictionary<string,object> GetProductByID(int productID)
        {
            string query = $"select " +
    $"Products.id,product_amount,product_import_money,product_sell_money," +
    $"design_name,manufacturer_name,color_name,screen_name,screen_size from Products " +
    $"inner join Designs on Products.design_id = Designs.id " +
    $"inner join Manufacturer on Manufacturer.id = Products.manufacturer_id " +
    $"inner join Colors on Colors.id = Products.color_id " +
    $"inner join Screen on Screen.id = Products.screen_id " +
    $"inner join ScreenSize on ScreenSize.id = Products.size_id " +
    $"where Products.id = @id";
            db.SetQuery(query);
            return db.LoadRow(productID);
        }


        public void InsertToImportBill(int supplier_id, int staff_id)
        {
            string query = "insert into ImportBill(supplier_id,staff_id,import_date) values (@supplier_id,@staff_id,@import_date)";
            db.SetQuery(query);
            var res = db.Excute(supplier_id, staff_id, DateTime.UtcNow.AddHours(7));
        }
        public void InsertToImportBillDetail(int product_id, int import_amount, int price)
        {
            string queryToGetBill = "select TOP 1 id from ImportBill order by id desc ";
            db.SetQuery(queryToGetBill);
            int import_bill_id = int.Parse(db.LoadRow()["id"].ToString());

            string query = "insert into ImportBillDetail(product_id,import_amount,import_bill_id,price) values(@product_id,@import_amount,@import_bill_id,@price)";
            db.SetQuery(query);
            var res = db.Excute(product_id, import_amount, import_bill_id, price);
        }
        public void ChangePriceProduct(int price,int id)
        {
            string query = "update Products set product_import_money = @price,product_sell_money =@price_sell  where id =@id  ";
            db.SetQuery(query);
            var res = db.Excute(price,(float)price*1.1,id);
        }

        //Datatable
        public List<Dictionary<string,object>> GetAllImportBill(string value, int startIndex, int count)
        {
            string query = "select ImportBill.id,staff_name,supplier_name,import_date " +
                "from ImportBill inner join Staff on ImportBill.staff_id = Staff.id " +
                "inner join Supplier on ImportBill.supplier_id = Supplier.id " +
                "where import_date like @value " +
                "ORDER BY ImportBill.id OFFSET @startIndex ROWS FETCH NEXT @count ROWS ONLY; ";
            db.SetQuery(query);
            return db.LoadAllRows("%" + value + "%", startIndex, count);
        }
        public Dictionary<string, object> GetNumberImportBill(string value)
        {
            string query = "select count(*) as 'number' from ImportBill where import_date like @value ";
            db.SetQuery(query);
            return db.LoadRow("%" + value + "%");
        }

        public List<Dictionary<string,object>> GetDetailBillByBillID(int billID)
        {
            string query = "select ImportBillDetail.id,Products.id as 'Product ID',price,import_amount from ImportBillDetail inner join Products on ImportBillDetail.product_id = Products.id where import_bill_id = @id";
            db.SetQuery(query);
            return db.LoadAllRows(billID);
        }
    }
}
