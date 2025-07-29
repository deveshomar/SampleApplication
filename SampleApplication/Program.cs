// See https://aka.ms/new-console-template for more information
using SampleApplication.CsharpPrograms;
using SampleApplication.InterfaceWithDI;
using System.Runtime.CompilerServices;
using System.Text;
using static SampleApplication.Delegates.MathDelegatesExample;

StringProgramData obj = new StringProgramData();

string data= obj.ReverseTheString("DEvesh omar");

obj.ReverseTheStringWithSpecialSybmbol("This-is-my-room",'-');

var datavalue=obj.printreverse("Rajkumar");

Console.WriteLine(  data);
