using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SampleApplication
{
   

    public class CustomerClsData
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
    internal class ValidationCShaepClass
    {
        public void ValidateCustomer()
        {
            CustomerClsData customer = new CustomerClsData
            {
                Name = "",
                Age = 15,
                Email = "bademail"
            };

            var context = new ValidationContext(customer);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(customer, context, results, true);

            if (!isValid)
            {
                foreach (var validationResult in results)
                    Console.WriteLine("Validation Error: " + validationResult.ErrorMessage);
            }
            else
            {
                Console.WriteLine("Customer is valid.");
            }

        }
    }
}
