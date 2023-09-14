using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Models
{
    internal class m_Staff
    {
        Database db = new Database();

        public List<Dictionary<string,object>> getAllStaff()
        {
            string query = "select *,Staff.id as 'staff_id' from Staff inner join Work on Staff.staff_work_id = Work.id;";
            db.SetQuery(query);
            return db.LoadAllRows();
        }

        public List<Dictionary<string, object>> getStaffByValue(string value)
        {
            string query = "select * from Staff inner join Work on Staff.staff_work_id = Work.id where staff_name like @value";
            db.SetQuery(query);
            return db.LoadAllRows("%" + value + "%");
        }
        public void AddNewStaff(string names,bool gender,string phoneNumber,string dob,string address,string email,int id_Work)
        {
            string query = "insert into Staff " +
                "(staff_name,staff_gender,staff_phoneNumber,staff_dob,staff_address,staff_email,staff_work_id) values " +
                "(@name,@gender,@phoneNumber,@dob,@address,@email,@id_Work);";
            db.SetQuery(query);
            var data = db.Excute(names,gender,phoneNumber,dob,address,email,id_Work);
        }
    }
}
