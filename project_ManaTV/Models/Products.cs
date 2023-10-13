using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Manufacturer_id { get; set; }
        public int Design_id { get; set; }
        public int Color_id { get; set; }
        public int Screen_id { get; set; }
        public int Size_id { get; set; }
        public int Country_id { get; set; }
        public int Product_amount { get; set; }
        public int Product_status { get; set; }
    }
}
