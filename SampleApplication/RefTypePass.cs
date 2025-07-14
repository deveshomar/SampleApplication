using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class ProductService1
    {
        public void UpdateProductByValue(Product product)
        {
            product.Price += 100; // ✅ This will reflect outside

            product = new Product { Name = "New Product", Price = 999 }; // ❌ This won't reflect outside
            Console.WriteLine($"Inside method (by value): {product.Name}, {product.Price}");
        }

        /*
         * 
         * Product p = new Product { Name = "Phone", Price = 500 };
        ProductService service = new ProductService();

        service.UpdateProductByValue(p);

        Console.WriteLine($"Outside method: {p.Name}, {p.Price}");
         */


        public void UpdateProductByRef(ref Product product)
        {
            product.Price += 200;  // ✅ Will reflect outside

            product = new Product { Name = "Refreshed Product", Price = 888 }; // ✅ Reassignment reflects outside
            Console.WriteLine($"Inside method (by ref): {product.Name}, {product.Price}");


            /*
        * Product p = new Product { Name = "Laptop", Price = 1000 };
        ProductService service = new ProductService();

        service.UpdateProductByRef(ref p);

        Console.WriteLine($"Outside method: {p.Name}, {p.Price}");
             */
        }
    }
}
