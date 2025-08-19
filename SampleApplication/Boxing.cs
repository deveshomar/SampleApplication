using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public  class Boxing
    {
        public void BoxingDemo()
        {
            // Boxing: Converting a value type to an object type
            int number = 42;
            object boxedNumber = number; // Boxing
                                         // Unboxing: Converting an object type back to a value type

            Console.WriteLine(boxedNumber);


            int unboxedNumber = (int)boxedNumber; // Unboxing
            Console.WriteLine($"Original Number: {unboxedNumber}");

            int unboxedNumber1 = Convert.ToInt16(boxedNumber);// Unboxing
            Console.WriteLine($"Original Number: {unboxedNumber1}");


           
        }
    }
}
