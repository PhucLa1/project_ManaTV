using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Models
{
    internal class m_Work
    {
        Database db = new Database();

        public List<Dictionary<string,object>> getAllWork()
        {
            string query = "Select * from Work";
            db.SetQuery(query);
            return db.LoadAllRows();
        }
    }
}
