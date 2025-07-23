// See https://aka.ms/new-console-template for more information
using SampleApplication;
using System.Runtime.CompilerServices;
using System.Text;
using static SampleApplication.MathDelegatesExample;


string str = "Devesh";
str = str + " omar";

str = str + " City is Noida";
str = str + " State  is UP";

Console.WriteLine(  "final stringis -"+str);

StringBuilder sb = new StringBuilder(); 
sb.Append("Devesh ");
sb.Append("omar  ");

sb.Append("City is Noida  ");

sb.Append("State  is UP");

Console.WriteLine("final string from string builder -" + sb.ToString());