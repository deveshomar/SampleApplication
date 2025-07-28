using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Files
{
    public class DirectoryFolderDispalay
    {
        public void ReadFolder(string path)
        {
           
            if (Directory.Exists(path))
            {
                Console.WriteLine("Directories:");
                string[] directories = Directory.GetDirectories(path);
                foreach (string dir in directories)
                {
                    Console.WriteLine(dir);
                }

                Console.WriteLine("\nFiles:");
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
    }
}
