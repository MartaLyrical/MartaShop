using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MartaShop.Core.Models;

namespace MartaShop.Core.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}

