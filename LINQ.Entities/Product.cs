using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    public partial class Product
    {
        public int productId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
