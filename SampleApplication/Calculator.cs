using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{

    // internal --> public with in library
    // public --> every where
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
       

        public double Add(double a, double b)
        {
           
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        /*
         * Calculator calc = new Calculator();

        Console.WriteLine("Add: " + calc.Add(10, 20));
        Console.WriteLine("Subtract: " + calc.Subtract(50.5, 30.2));
        Console.WriteLine("Multiply: " + calc.Multiply(6, 7));
        Console.WriteLine("Divide: " + calc.Divide(100, 4));
         */
    }
}
