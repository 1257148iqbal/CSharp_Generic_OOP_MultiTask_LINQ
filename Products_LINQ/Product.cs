using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_LINQ
{
   public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }

        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductModel ProductModel { get; set; }


        public Product()
        {

        }        
        public Product(int productID, string name, string productNumber, string color, double standardCost, double listPrice, int size, double weight, int productCategoryID, int productModelID): this()
        {
            ProductID = productID;
            Name = name;
            ProductNumber = productNumber;
            Color = color;
            StandardCost = standardCost;
            ListPrice = listPrice;
            Size = size;
            Weight = weight;
            ProductCategoryID = productCategoryID;
            ProductModelID = productModelID;
        }
    }
}
