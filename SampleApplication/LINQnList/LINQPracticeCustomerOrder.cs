using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.LINQnList
{
    public class clsProductdata
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class OrderItem
    {
        public clsProductdata Product { get; set; }
        public int Quantity { get; set; }
    }
    public class clsOrderdata
    {
        public int OrderId { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public DateTime OrderDate { get; set; }
    }

    public class clsClassCustomerdata
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<clsOrderdata> Orders { get; set; } = new();
    }
    internal class LINQPracticeCustomerOrder
    {
        public static List<clsOrderdata> GetOrdersFromNoida(List<clsClassCustomerdata> customers)
        {
            return customers
                .Where(c => c.City.Equals("Noida", StringComparison.OrdinalIgnoreCase))
                .SelectMany(c => c.Orders)
                .ToList();
        }

        public static List<clsClassCustomerdata> GetSampleData()
        {
            var product1 = new clsProductdata { Id = 1, Name = "Laptop" };
            var product2 = new clsProductdata { Id = 2, Name = "Phone" };
            var product3 = new clsProductdata { Id = 3, Name = "Tablet" };

            var customer1 = new clsClassCustomerdata
            {
                CustomerId = 1,
                Name = "Alice",
                City = "Noida",
                Orders = new List<clsOrderdata>
        {
            new clsOrderdata
            {
                OrderId = 101,
                OrderDate = DateTime.Now.AddHours(-30),
                Items = new List<OrderItem>
                {
                    new OrderItem { Product = product1, Quantity = 1 },
                    new OrderItem { Product = product2, Quantity = 2 }
                }
            }
        }
            };

            var customer2 = new clsClassCustomerdata
            {
                CustomerId = 2,
                Name = "Bob",
                City = "Delhi",
                Orders = new List<clsOrderdata>
        {
            new clsOrderdata
            {
                OrderId = 102,
                OrderDate = DateTime.Now.AddDays(-3),
                Items = new List<OrderItem>
                {
                    new OrderItem { Product = product3, Quantity = 2 }
                }
            }
        }
            };

            return new List<clsClassCustomerdata> { customer1, customer2 };
        }

    }
}
/*
 var customers = GetSampleData();

    var noidaOrders = GetOrdersFromNoida(customers);

    Console.WriteLine("Orders from Noida:");
    foreach (var order in noidaOrders)
    {
        Console.WriteLine($"Order ID: {order.OrderId}, Date: {order.OrderDate}");
    }

var topProduct = GetHighSellingProduct(customers);
    Console.WriteLine($"High selling product: {topProduct?.Name}");

    var lowProduct = GetLeastSellingProduct(customers);
    Console.WriteLine($"Least selling product: {lowProduct?.Name}");

    var topCustomer = GetTopCustomer(customers);
    Console.WriteLine($"Top customer: {topCustomer?.Name}");

    var recentOrders = GetRecentOrders(customers);
    Console.WriteLine("Recent Orders (last 48 hours):");
    foreach (var order in recentOrders)
    {
        Console.WriteLine($"Order ID: {order.OrderId}, Date: {order.OrderDate}");
    }
 */