using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class PersonData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class EMPRWToFile
    {
        public void Write()

        {
            PersonData person = new PersonData { Name = "Alice", Age = 30 };

            // Serialize object to JSON string
            string jsonString = JsonSerializer.Serialize(person);

            // Write JSON string to file
            File.WriteAllText("person.json", jsonString);

            Console.WriteLine("Person object written to file.");
        }

        public void Read()
        {
            if (File.Exists("person.json"))
            {
                // Read JSON string from file
                string jsonString = File.ReadAllText("person.json");

                // Deserialize JSON to Person object
                PersonData person = JsonSerializer.Deserialize<PersonData>(jsonString);

                Console.WriteLine($"Name: {PersonData.Name}, Age: {PersonData.Age}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
       
    }
}
/*
 *Use JsonSerializer.Serialize() to convert object → JSON string

Use File.WriteAllText() to save the string to a file

Use File.ReadAllText() to read the string back

Use JsonSerializer.Deserialize<T>() to convert JSON string → object

Using JSON serialization (recommended for readability and interoperability)

Using binary serialization (less common now, requires [Serializable] attribute) 
 */