using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class Productcls
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Productcls(int id, string name, double price)
        {
            ProductId = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} (${Price})";
        }
    }
    // Ordercls Class
    public class Ordercls
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public List<Productcls> Products { get; set; }

        public Ordercls(int id, DateTime date)
        {
            OrderId = id;
            Date = date;
            Products = new List<Productcls>();
        }

        public void AddProduct(Productcls product)
        {
            Products.Add(product);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }

        public override string ToString()
        {
            string productList = string.Join(", ", Products);
            return $"Order #{OrderId} on {Date.ToShortDateString()} - Products: {productList} | Total: ${GetTotal():0.00}";
        }
    }

    // Customercls Class
    public class Customercls
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Ordercls> Orders { get; set; }

        public Customercls(int id, string name, string email)
        {
            CustomerId = id;
            Name = name;
            Email = email;
            Orders = new List<Ordercls>();
        }

        public void AddOrder(Ordercls order)
        {
            Orders.Add(order);
        }

        public override string ToString()
        {
            string orderList = string.Join("\n", Orders);
            return $"Customer: {Name} ({Email})\nOrders:\n{orderList}";
        }
    }
}
/*
 // Create Productcls objects
        Productcls p1 = new Productcls(1, "Laptop", 999.99);
        Productcls p2 = new Productcls(2, "Mouse", 25.50);
        Productcls p3 = new Productcls(3, "Keyboard", 45.00);
        Productcls p4 = new Productcls(4, "Monitor", 150.75);

        // Create Ordercls and add Productcls
        Ordercls order1 = new Ordercls(1001, DateTime.Now);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Ordercls order2 = new Ordercls(1002, DateTime.Now.AddDays(-2));
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        // Create Customercls and add Ordercls
        Customercls customer = new Customercls(1, "Alice Smith", "alice@example.com");
        customer.AddOrder(order1);
        customer.AddOrder(order2);

        // Display the customer details
        Console.WriteLine(customer);
 */