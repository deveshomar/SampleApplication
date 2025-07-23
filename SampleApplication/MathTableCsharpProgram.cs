using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    internal class MathTableCsharpProgram
    {
        public void PrintTable()
        {
            Console.WriteLine("Multiplication Tables from 1 to 10\n");

            for (int i = 1; i <= 10; i++) // Table number
            {
                Console.WriteLine($"--- Table of {i} ---");

                for (int j = 1; j <= 10; j++) // Multiplier
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine(); // Add space after each table
            }

            Console.WriteLine("Done!");
        }
    }
}
