using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_LINQ
{
   public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductCategory ()
        {
            Products = new HashSet<Product>();
        }
        public ProductCategory(int productCategoryID, string name): this()
        {
            ProductCategoryID = productCategoryID;
            Name = name;
        }
    }
}
