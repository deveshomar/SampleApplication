using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SampleApplication.MathDelegatesExample;

namespace SampleApplication
{

    //we cannot pass function as parameter.
    //we can pass only objects to funciton 
    // Delegates  -> functions to pointers
    // type of object where we can put ref of functions.

    public class MathDelegatesExample
    {
        public delegate int MathOperation(int x, int y);

        public static int PercaentCalulation(int x, int y)
        {

            int z = x + y;
            return z * 2/100;
        }

        public static int  Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public void Execute()
        {
            MathOperation objMatch = Add;
            Console.WriteLine("Add opeation result-" +objMatch(5, 6).ToString());

            MathOperation objMatch1 = Multiply;
            Console.WriteLine("Multiply opeation result-" + objMatch1(5, 6).ToString());

            MathOperation objMatch2 = Sub;
            Console.WriteLine("sub opeation result-" + objMatch2(55, 5).ToString());



        }
    }

    public class MathExtension
    {
        public void DoOpeation(MathOperation objMathOperation)
        {
           int data= objMathOperation.Invoke(55, 77);
           Console.WriteLine("Add opeation result-" + data.ToString());

        }

    }


    internal class Delegates
    {  
        //EXample 1
        delegate void Notify(string message); // Step 1: Declare delegate
        static void ShowMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
      

        public void Execute()
        {
            Notify notifier = ShowMessage;  // Step 2: Assign method to delegate
            notifier( "Hello from delegate!"); // Step 3: Invoke delegate
        }
               ////EXample 2

        static int Add(int a, int b)
        {
            return a + b;
        }

        public void ExcuteWithoutDelegate()
        {
            int result = Add(5, 3);
            Console.WriteLine("Sum: " + result);
        }


        //Example 3
        delegate int Operation(int a, int b); // Delegate definition

        public void ExecuteDelegatesData()
        {
            //delegate (int a, int b) { return a + b; } is the anonymous method.
            //No method name is used — it’s "anonymous".

            Operation add = delegate (int a, int b)
            {
                return a + b;
            };

            int result = add(5, 3);
            Console.WriteLine("Sum: " + result);
        }

        //example 4
        //(a, b) => a + b is a lambda expression.
        //It takes parameters a and b, and returns their sum.
        public void ExecithWithDelegates()
        {
            Operation add = (a, b) => a + b;
            int result = add(5, 3);
            Console.WriteLine("Sum: " + result);
        }
    }
}
/*
 
MathDelegatesExample obj = new MathDelegatesExample();
obj.Execute();


MathExtension objMathExtension = new MathExtension();
MathOperation objMatch = MathDelegatesExample.Add;

objMathExtension.DoOpeation(objMatch);

MathOperation objMatch12 = MathDelegatesExample.Multiply;
objMathExtension.DoOpeation(objMatch12);


MathOperation objMatch123 = MathDelegatesExample.Sub;
objMathExtension.DoOpeation(objMatch123);

MathOperation objMatch1235 = MathDelegatesExample.PercaentCalulation;
objMathExtension.DoOpeation(objMatch1235);
 */