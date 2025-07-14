using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    internal class GenericCalculator
    {
        public T Add<T>(T a, T b) where T : INumber<T>
        {
            return a + b;
        }

        public T Subtract<T>(T a, T b) where T : INumber<T>
        {
            return a - b;
        }

        
    }
}

/*
 *     var calc = new GenericCalculator();

        int intResult = calc.Add(10, 5);
        double doubleResult = calc.Add(10.5, 2.3);

        Console.WriteLine($"Int Add: {intResult}");
        Console.WriteLine($"Double Add: {doubleResult}");

        Console.WriteLine($"Int Subtract: {calc.Subtract(10, 5)}");
        Console.WriteLine($"Double Subtract: {calc.Subtract(10.5, 2.3)}");
 * 
 * 
 */
