using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{

    // Interview question ref and out 
    public class ProductServiceOut
    {
        public void GetDiscountedPrice(out decimal discountedPrice)
        {
            discountedPrice = 450; // Must assign before returning
        }

        /*
         * ProductService service = new ProductService();
         decimal finalPrice;

         service.GetDiscountedPrice(out finalPrice);

         Console.WriteLine($"Discounted Price = {finalPrice}");
         */

    }


    public class ProductServiceByRef
    {
        public void UpdatePriceByRef(ref decimal price)
        {
            price = price + 100;
            Console.WriteLine($"Inside method (by ref): New Price = {price}");
        }

        /*
         * ProductService service = new ProductService();
        decimal originalPrice = 500;

        service.UpdatePriceByRef(ref originalPrice);

        Console.WriteLine($"Outside method: Updated Price = {originalPrice}");
         * 
         * 
         */
    }

    public class ProductService
    {
        public void UpdatePriceByValue(decimal price)
        {
            price = price + 100; // Update inside the method
            Console.WriteLine($"Inside method (by value): New Price = {price}");

            /*
              ProductService service = new ProductService();
              decimal originalPrice = 500;

            service.UpdatePriceByValue(originalPrice);

             Console.WriteLine($"Outside method: Original Price = {originalPrice}");
            
             */


        }


    }
}
