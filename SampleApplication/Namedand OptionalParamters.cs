using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleApplication
{
    internal class Namedand_OptionalParamters
    {
        static void PrintUserInfo(string name, int age = 18, string city = "Unknown")
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }

        public void Print()
        {

            Console.WriteLine("--- Examples of Named and Optional Parameters ---");

            // 1. Using all positional parameters
            PrintUserInfo("Alice", 25, "New York");

            // 2. Using default values (optional parameters)
            PrintUserInfo("Bob");

            // 3. Mixing positional and named
            PrintUserInfo("Charlie", city: "London");

            // 4. Using all named parameters
            PrintUserInfo(age: 22, city: "Paris", name: "David");

            // 5. Only one named, rest default
            PrintUserInfo(name: "Eva");

        }
    }

  
    
}
