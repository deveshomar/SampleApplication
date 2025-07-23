using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    internal class FuncDelegateExample1
    {
        static int Square(int x)
        {
            return x * x;
        }

        public void Execute()
        {
            Func<int, int> squareFunc = Square;

            // Call the delegate
            int result = squareFunc(5);
            Console.WriteLine("Square using method: " + result); // Output: 25
        }

        public void ExecuteWithLambda()
        {
            // Use lambda expression instead of separate method
            Func<int, int> squareFunc = x => x * x;

            int result = squareFunc(5);
            Console.WriteLine("Square using lambda: " + result); // Output: 25
        }
    }
}
