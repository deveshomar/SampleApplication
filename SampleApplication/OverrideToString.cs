using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{




    internal class OverrideToString
    {
    }

  

public class CustomerClsDataValue
    {
        public int Id;
        public string Name;
        public string Email;
        public string Phone;
        public string Address;
        public string City;
        public string Country;
        public string PostalCode;
        public string Gender;
        public DateTime DateOfBirth;
        public string CustomerType;
        public bool IsActive;
        public DateTime RegisteredDate;
        public string Notes;
        public int LoyaltyPoints;

        public override string ToString()
        {
            return $"Customer Details:\n" +
                   $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Email: {Email}\n" +
                   $"Phone: {Phone}\n" +
                   $"Address: {Address}\n" +
                   $"City: {City}\n" +
                   $"Country: {Country}\n" +
                   $"PostalCode: {PostalCode}\n" +
                   $"Gender: {Gender}\n" +
                   $"DateOfBirth: {DateOfBirth}\n" +
                   $"CustomerType: {CustomerType}\n" +
                   $"IsActive: {IsActive}\n" +
                   $"RegisteredDate: {RegisteredDate}\n" +
                   $"Notes: {Notes}\n" +
                   $"LoyaltyPoints: {LoyaltyPoints}";
        }
    }


    /*
     Customer obj = new Customer
        {
            Id = 1,
            Name = "John Doe",
            Email = "john@example.com",
            Phone = "1234567890",
            Address = "123 Main St",
            City = "New York",
            Country = "USA",
            PostalCode = "10001",
            Gender = "Male",
            DateOfBirth = new DateTime(1990, 1, 1),
            CustomerType = "Premium",
            IsActive = true,
            RegisteredDate = DateTime.Now,
            Notes = "Frequent buyer",
            LoyaltyPoints = 1200
        };

        Console.WriteLine(obj); // <-- This will now use your overridden ToString()
     */

}
