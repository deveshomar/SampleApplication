using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Generic
{

   public class EmpClassWithLambdaExpressionFunction
    {
        public void PrintData(string printmessage)
        {
            Console.WriteLine(  "Mesage of data is -> "+printmessage);
        }

        public void PrintDataWithLabda(string printmessage) => Console.WriteLine("Mesage of data is -> " + printmessage);

    }


    public class MathUtils
    {
        //Another way to call

        public int Add(int a, int b) => a + b;
        public double SquareRoot(double x) => Math.Sqrt(x);
    }

    public class ClassOfPerson
    {
        public string FirstName { get; }
        public string LastName { get; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
/*
     MathUtils obj = new MathUtils();
    int result = obj.Add(5, 666);
    Console.WriteLine("Math Uilts data -> " + result.ToString());
*/