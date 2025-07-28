using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    internal class StringPrograms
    {
        public void Palimdrom(string input)
        {
            
            bool isPalindrome = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("The string is a palindrome.");
            else
                Console.WriteLine("The string is not a palindrome.");
        }
        public void Reverse(string input)
        {
            Console.Write("Enter a string: ");
           
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i]; // Adding characters from the end
            }

            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}
