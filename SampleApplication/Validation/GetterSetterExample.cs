using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Validation
{
    public class ClassCustomerExample
    {
        private int _age;
        public int id { get; set; } 
        public string name { get; set; }    
        public int age {
            get;
            set
            {
                if (value >= 18 && value <= 100)
                    _age = value;
                else
                    throw new ArgumentException("Age must be between 18 and 100.");
            }

        }    
        public string description { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        

    }


    class CustomerClassData
    {
        private int _age;
        private string _phoneNumber;
        private decimal _salary;

        // Property for Age
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18 && value <= 100)
                    _age = value;
                else
                    throw new ArgumentException("Age must be between 18 and 100.");
            }
        }

        // Property for PhoneNumber
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 10 && long.TryParse(value, out _))
                    _phoneNumber = value;
                else
                    throw new ArgumentException("Phone number must be exactly 10 digits.");
            }
        }

        // Property for Salary
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                    _salary = value;
                else
                    throw new ArgumentException("Salary must be greater than 0.");
            }
        }

        // Optional: Display info method
        public void DisplayInfo()
        {
            Console.WriteLine($"Age: {Age}, Phone: {PhoneNumber}, Salary: {Salary:C}");
        }
    }
}

/*
 try
        {
            Customer cust = new Customer();
            cust.Age = 25;
            cust.PhoneNumber = "9876543210";
            cust.Salary = 50000;

            cust.DisplayInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
 * 
 * 
cust.Age = 12;                   // ❌ Throws "Age must be between 18 and 100"
cust.PhoneNumber = "12345";      // ❌ Throws "Phone number must be exactly 10 digits"
cust.Salary = -100;              // ❌ Throws "Salary must be greater than 0"
 */