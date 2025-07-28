using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Files
{
    internal class FilesIO
    {
        public void Write(string path )
        {
            string[] lines = {
            "Hello, this is line 1.",
            "This is line 2.",
            "Writing to a file in C# is easy!"
        };

            // Write all lines to output.txt (creates or overwrites the file)
            File.WriteAllLines(path, lines);

            Console.WriteLine("Data written to file successfully.");
        }

        public void WriteAppend(string path, string[] lines)
        {
           

            // Write all lines to output.txt (creates or overwrites the file)
            File.AppendAllLines(path, lines);

            Console.WriteLine("Data written to file successfully.");
        }
        public void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted.");
            }
        }


        
        public void Read(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                Console.WriteLine("Contents of the file:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
/*
 * File.WriteAllLines() writes an array of strings to the file.

File.ReadAllLines() reads all lines from the file into a string array.

The file path "output.txt" is relative to the program’s working directory. You can also use full paths.
 
Create	File.Create()	Creates file
Write text	File.WriteAllText()	Overwrites content
Append text	File.AppendAllText()	Adds to file end
Write lines	File.WriteAllLines()	Writes array of lines
Read text	File.ReadAllText()	Reads entire file
Read lines	File.ReadAllLines()	Reads into array
Check exist	File.Exists()	Boolean check
Delete	File.Delete()	Remove file
Copy	File.Copy()	Copy file
Move/Rename	File.Move()	Move or rename file
StreamWriter/Reader	StreamWriter / StreamReader	Fine-grained control
Async read/write	File.ReadAllTextAsync() / File.WriteAllTextAsync()	For async apps


FilesIO obj = new FilesIO();
string filepath = "C:\\Users\\admin\\source\\repos\\SampleApplication\\FilesData\\samplefile.txt";


for(int i = 0; i <10; i++)
{
    string[] lines = {
             "This is first line of content number = "+i.ToString(), 
            "Hello, this is line 1.",
            "This is line 2.",
            "Writing to a file in C# is easy!",
             "================================"
        };

    obj.WriteAppend(filepath, lines);


}



obj.Read(filepath);


 */
