using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Repository
{
    public class ShiftWorkRespository
    {
        Database db = new Database();

        public Dictionary<string,object> GetEmployeeById(int id)
        {
            string query = "select * from Staff where id =@id ";
            db.SetQuery(query);
            return db.LoadRow(id);
        }
        public void UpdateEmployee(string value,int id)
        {
            string query = "update Staff set shiftwork = @value  where id =@id ";
            db.SetQuery(query);
            var res = db.Excute(value,id);
        }
    }
}
