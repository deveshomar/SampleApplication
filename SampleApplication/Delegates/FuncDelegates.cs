using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Delegates
{
//Func<int> No input, returns int
//Func<int, int>  One input int, returns int
//Func<int, int, int>	Two inputs int, returns int
//Func<string, bool>	One input string, returns bool


    // interview 
    internal class FuncDelegates
    {
        static string Greet(string name)
        {
            return "Hello, " + name;
        }

        static FuncDelegates() { }
        public void ExecuteFunc()
        {
            Func<string, string> greetFunc = Greet;

            string message = greetFunc("Devesh");
            Console.WriteLine(message); // Output: Hello, Alice
        }
    }
}
