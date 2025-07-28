using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Static
{
    public static class MathUtility
    {
        static MathUtility()
        {
            Console.WriteLine("Static constructor called once.");
        }

        public static int Square(int number)
        {
            return number * number;
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        /*
         * 
        int sq = MathUtility.Square(5);
        Console.WriteLine("Square: " + sq);

        double area = MathUtility.CircleArea(3);
        Console.WriteLine("Circle Area: " + area);
         */
    }

    public static class ConfigManager
    {
        public static string DbConnectionString;

        static ConfigManager()
        {
            // Simulate reading from config
            DbConnectionString = "Server=.;Database=MyDB;Trusted_Connection=True;";
            Console.WriteLine("Static constructor called.");
        }

        public static void PrintConfig()
        {
            Console.WriteLine($"DB: {DbConnectionString}");
        }

        /*Limitation	Description
❌ Can't use interfaces	No DI (Dependency Injection)
❌ Can't be inherited	No polymorphism
❌ Not thread-safe by default	You must manage synchronization
❌ Hard to unit test	Static classes are difficult to mock/test
        */
    }
}
