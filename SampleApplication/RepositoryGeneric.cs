using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductDataData
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }


public class Repository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
            Console.WriteLine($"{typeof(T).Name} added.");
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public void Remove(T item)
        {
            _items.Remove(item);
            Console.WriteLine($"{typeof(T).Name} removed.");
        }
    }
}

/*
  // Customer repository
        var customerRepo = new Repository<Customer>();
        customerRepo.Add(new Customer { Id = 1, Name = "Alice" });
        customerRepo.Add(new Customer { Id = 2, Name = "Bob" });

        // ProductData repository
        var ProductDataRepo = new Repository<ProductData>();
        ProductDataRepo.Add(new ProductData { Id = 101, Title = "Laptop" });
        ProductDataRepo.Add(new ProductData { Id = 102, Title = "Smartphone" });

        Console.WriteLine("\nCustomers:");
        foreach (var customer in customerRepo.GetAll())
        {
            Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
        }

        Console.WriteLine("\nProductDatas:");
        foreach (var ProductData in ProductDataRepo.GetAll())
        {
            Console.WriteLine($"Id: {ProductData.Id}, Title: {ProductData.Title}");
        }

 */