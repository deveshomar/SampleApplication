using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SampleApplication.Files
{
    public class PersonData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class EMPRWToFile
    {
        public void Write(string jsonpath)

        {
            PersonData person = new PersonData { Name = "Devesh666787", Age = 30 };

            // Serialize object to JSON string
            string jsonString = JsonSerializer.Serialize(person);

            // Write JSON string to file
            File.WriteAllText(jsonpath, jsonString);

            Console.WriteLine("Person object written to file.");
        }

        public static void Read(string path)
        {
            if (File.Exists(path))
            {
                // Read JSON string from file
                string jsonString = File.ReadAllText(path);

                // Deserialize JSON to Person object
                PersonData person = JsonSerializer.Deserialize<PersonData>(jsonString);

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