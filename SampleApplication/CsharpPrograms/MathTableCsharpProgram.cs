using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.CsharpPrograms
{
    internal class MathTableCsharpProgram
    {



        public void PrintTableforNumeer(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:\n");
            for (int i = 1; i <= 10; i++) // Multiplier
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
            Console.WriteLine("Done!");
        }



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
/*
 * 

MathTableCsharpProgram objt = new MathTableCsharpProgram();

for (int i = 0; i < 100; i++)
{
 
    Console.WriteLine("=========Table of ="+i.ToString());
    objt.PrintTableforNumeer(i);
    Console.WriteLine(  "===============================");
}

 */