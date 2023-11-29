using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Models
{
    public class ProductViewModel : Product
    {
        public string ManufacturerName { get; set; }
        public string DesignName { get; set; }
        public string ColorName { get; set; }
        public string ScreenName { get; set; }
        public string SizeName { get; set; }
        public string CountryName { get; set; }

    }
}
