// See https://aka.ms/new-console-template for more information
using SampleApplication;


// Pass by value and pass by ref.

Calculator calc = new Calculator();

Console.WriteLine("Add: " + calc.Add(10, 20));
Console.WriteLine("Subtract: " + calc.Subtract(50.5, 30.2));
Console.WriteLine("Multiply: " + calc.Multiply(6, 7));
Console.WriteLine("Divide: " + calc.Divide(100, 4));

