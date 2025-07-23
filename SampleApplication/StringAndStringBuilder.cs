using SampleApplication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


//string vs StringBuilder
//🔹 string (Immutable)
//Every change creates a new string in memory.

//Ideal for light usage, like small message formatting.

//🔹 StringBuilder(Mutable)
//Efficient for repeated changes, especially in loops.


namespace SampleApplication
{
    internal class StringAndStringBuilder
    {
        public string GetString()
        {
            string result = "";

            for (int i = 0; i < 10000; i++)
            {
                result += i + " ";
            }
            return result;

        }

        public void TimeForString()
        {
            string result = "";
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                result += i + " ";
            }

            sw.Stop();
            Console.WriteLine("String time: " + sw.ElapsedMilliseconds + " ms");
        }
        public void TimeForStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i).Append(" ");
            }

            sw.Stop();
            Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
