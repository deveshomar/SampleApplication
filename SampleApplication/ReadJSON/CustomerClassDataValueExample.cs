using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.ReadJSON
{
    internal class CustomerClassDataValueExample
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
/*
 // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("customerData.json", optional: false, reloadOnChange: true)
            .Build();

        // Bind to custom class
        var customer = new CustomerData();
        configuration.Bind(customer);

        // Use it
        Console.WriteLine($"Customer ID: {customer.CustomerId}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine($"Is Active: {customer.IsActive}");
 */