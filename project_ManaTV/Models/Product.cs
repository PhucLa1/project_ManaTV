using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public int DesignId { get; set; }
        public int ColorId { get; set; }
        public int ScreenId { get; set; }
        public int SizeId { get; set; }
        public int CountryId { get; set; }
        public int ProductAmount { get; set; }
        public int ProductImportMoney { get; set; }
        public int? ProductSellMoney { get; set; } = 0;
        public bool IsDeleted { get; set; }

    }
}
