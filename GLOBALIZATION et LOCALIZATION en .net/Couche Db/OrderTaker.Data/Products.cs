using OrderTaker.SharedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaker.Data
{
    public static class Products
    {
        public static List<Product> GetProducts()
        {
            var p = new List<Product>()
            {
                new Product() { ProductId = 1, 
                                ProductName = Properties.Resources.Product_UniversalTranslator,
                                Price = ConvertFromDollar(199.99M) },
                new Product() { ProductId = 2,
                                ProductName = Properties.Resources.Product_CaptainsChairVinyl,
                                Price = ConvertFromDollar(549.99M) },
                new Product() { ProductId = 3,
                                ProductName = Properties.Resources.Product_CaptiainsChairLeather,
                                Price = ConvertFromDollar(2999.99M) },
                new Product() { ProductId = 4,
                                ProductName = Properties.Resources.Product_LaserBeacon,
                                Price = ConvertFromDollar(99.95M) },
                new Product() { ProductId = 5,
                                ProductName = Properties.Resources.Product_SpaceSuit,
                                Price = ConvertFromDollar(599.99M) },
                new Product() { ProductId = 6,
                                ProductName = Properties.Resources.Product_WarpEngine,
                                Price = ConvertFromDollar(1599.99M) },
                new Product() { ProductId = 7,
                                ProductName = Properties.Resources.Product_Moonbase,
                                Price = ConvertFromDollar(2999999.99M) },
                new Product() { ProductId = 8,
                                ProductName = Properties.Resources.Product_Starship,
                                Price = ConvertFromDollar(5999999.99M) },
                new Product() { ProductId = 9,
                                ProductName = string.Format(Properties.Resources.Product_NameBadge, "John"),
                                Price = ConvertFromDollar(0.99M) },
                new Product() { ProductId = 10,
                                ProductName = string.Format(Properties.Resources.Product_NameBadge, "Dante"),
                                Price = ConvertFromDollar(0.99M) },
                new Product() { ProductId = 11,
                                ProductName = string.Format(Properties.Resources.Product_NameBadge, "Isaac"),
                                Price = ConvertFromDollar(0.99M) },
            };
            return p;
        }

        public static decimal ConvertFromDollar(decimal dollarAmount)
        {
            return dollarAmount * decimal.Parse(Properties.Resources.ConversionFromDollar);
        }
    }
}
