using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    /*
         IAnimal dog = new Dog();
        dog.Speak();  // Output: Dog says: Woof!
  
    */
    public interface I1
    {
        void Show();
    }

    public interface I2
    {
        void Display();
    }

    public class MyClass : I1, I2
    {
        public void Show()
        {
            Console.WriteLine("I1 Show method implementation");
        }

        public void Display()
        {
            Console.WriteLine("I2 Display method implementation");
        }
    }
    /*
     MyClass obj = new MyClass();
        obj.Show();      // Output: I1 Show method implementation
        obj.Display();   // Output: I2 Display method implementation
     */


    //Interfaces I1 and I2 with Same Method Names

    public interface I1
    {
        void Print();
    }

    public interface I2
    {
        void Print();
    }

    public class MyClass : I1, I2
    {
        // Explicit implementation for I1.Print
        void I1.Print()
        {
            Console.WriteLine("I1 Print method");
        }

        // Explicit implementation for I2.Print
        void I2.Print()
        {
            Console.WriteLine("I2 Print method");
        }

        // Optional: public method to call either interface explicitly
        public void CallPrintMethods()
        {
            ((I1)this).Print();
            ((I2)this).Print();
        }

    }
    /*
        *MyClass obj = new MyClass();

        // Calls public method that calls both interface methods
        obj.CallPrintMethods();

        // Or call explicitly via interface references
        I1 i1 = obj;
        i1.Print();  // Output: I1 Print method

        I2 i2 = obj;
        i2.Print();  // Output: I2 Print method
     */
}


