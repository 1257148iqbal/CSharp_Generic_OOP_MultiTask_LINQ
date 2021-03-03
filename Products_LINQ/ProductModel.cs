using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_LINQ
{
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductModel ()
        {
            Products = new HashSet<Product>();
        }

        public ProductModel( int productModelID, string name): this ()
        {
            ProductModelID = productModelID;
            Name = name;
        }
    }
}
