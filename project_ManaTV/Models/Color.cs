using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ManaTV.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
