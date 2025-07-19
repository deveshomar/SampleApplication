using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    internal class Loops
    {
        public void ForLoops()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void ForLoopsEven()
        {
            for (int i = 2; i <= 100; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void ReverseForLoops()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        public void ReverseForLoopsEven()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
                i = i - 1;
            }
        }
        public void ForLoopsCutom()
        {
            for (int i = 0; i <= 1000; i += 2)
            {
                Console.WriteLine(i);
            }

        }
        public void ForLoopsArray()
        {
            string str = "hellow works";
            string[] fruits = { "Apple", "Banana", "Mango" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

        }
        public void ForLoopsNested()
        {
            for (int i = 1; i <= 10; i++) // Outer loop: rows (1 to 10)
            {
                for (int j = 1; j <= 10; j++) // Inner loop: columns (1 to 10)
                {
                    Console.Write($"{i * j,4}"); // Print product with spacing
                }
                Console.WriteLine(); // Move to the next line after each row
            }

        }

        public void SumOFIntegers()
        {
            int[] numbers = { 5, 10, 15, 20 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
               // sum += numbers[i];
                sum= sum + numbers[i];
            }

            Console.WriteLine($"Total sum: {sum}");

        }

        //interview 
        public void MaxFromIntegers()
        {
            int[] nums = { 2, 9, 4, 15, 7 };
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            Console.WriteLine($"Maximum value: {max}");

        }
        public void EvenIntegers()
        {
            int[] values = { 1, 4, 6, 7, 9, 10 };
            int count = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    count++;
                    //Console.WriteLine(values[i]);
                }
                else
                    Console.WriteLine(values[i]);
            }

            Console.WriteLine($"Even numbers count: {count}");

        }

        public void EvenNumbers()
        {
            Console.WriteLine($"Even numbers ");
            for (int i = 2; i <= 15000; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
