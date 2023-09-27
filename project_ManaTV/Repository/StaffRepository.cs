using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace project_ManaTV.Repository
{
    internal class StaffRepository
    {
        Database db = new Database();

        public List<Dictionary<string,object>> getAllStaff(int startIndex,int count)
        {
            string query = "select *,Staff.id as 'staff_id' from Staff inner join Work on Staff.staff_work_id = Work.id where staff_status = 1 ORDER BY 'staff_id' OFFSET @startIndex ROWS FETCH NEXT @count ROWS ONLY; ";
            db.SetQuery(query);
            return db.LoadAllRows(startIndex,count);
        }
        public Dictionary<string,object> getStaffById(int id)
        {
            string query = "select *,Staff.id as 'staff_id'" +
                " from Staff inner join Work on Staff.staff_work_id = Work.id where Staff.id = @id and staff_status = 1;";
            db.SetQuery(query);
            return db.LoadRow(id);
        }

        public List<Dictionary<string, object>> getStaffByValue(string value, int startIndex, int count)
        {
            string query = "select *,Staff.id as 'staff_id' from Staff inner join Work on Staff.staff_work_id = Work.id where staff_status = 1 and staff_name like @value ORDER BY staff_id OFFSET @startIndex ROWS FETCH NEXT @count ROWS ONLY; ";
            db.SetQuery(query);
            return db.LoadAllRows("%" + value + "%",startIndex,count);
        }
        public void AddNewStaff(string names,bool gender,string phoneNumber,string dob,string address,string email,int id_Work,string imagePath)
        {
            string query = "insert into Staff " +
                "(staff_name,staff_gender,staff_phoneNumber,staff_dob,staff_address,staff_email,staff_work_id,staff_image) values " +
                "(@name,@gender,@phoneNumber,@dob,@address,@email,@id_Work,@staff_image);";
            db.SetQuery(query);
            var data = db.Excute(names,gender,phoneNumber,dob,address,email,id_Work, imagePath);
        }
        public void UpdateStaff(string names, bool gender, string phoneNumber, string dob, string address, string email, int id_Work,string imagePath,int id)
        {
            string query = "UPDATE Staff SET staff_name = @name," +
                "staff_gender = @gender,staff_phoneNumber = @phoneNumber,staff_dob = @dob,staff_address = @address,staff_email = @email," +
                "staff_work_id = @id_Work, staff_image = @imagepath WHERE id = @id;";
            db.SetQuery(query);
            var data = db.Excute(names, gender, phoneNumber, dob, address, email, id_Work, imagePath,id);
        }
        public void SoftDeleteStaff(int id)
        {
            string query = "update Staff set staff_status = 0 where id = @id";
            db.SetQuery(query);
            var data = db.Excute(id);
        }

        public Dictionary<string,object> getNumberOfStaff(string value)
        {
            string query = "select Count(id) as 'number' from Staff where staff_status = 1 and staff_name like @value";
            db.SetQuery(query);
            return db.LoadRow("%" + value + "%") ;
        }
    }
}
