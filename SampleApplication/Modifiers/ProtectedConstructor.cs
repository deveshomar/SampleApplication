using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Modifiers
{
    public class Employee
    {
        protected string name;

        // Protected constructor
        protected Employee(string name)
        {
            this.name = name;
            Console.WriteLine($"Employee constructor called. Name: {name}");
        }
        public Employee()
        {
            Console.WriteLine(  "normal default construcor");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Employee name: {name}");
        }
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
            Console.WriteLine("Manager constructor called.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // ❌ This line will cause a compile error:
            // Employee emp = new Employee("John");

            // ✅ This works:
            Manager mgr = new Manager("Alice");
            mgr.ShowInfo();
        }
    }

    /*
     * 
            Real-World Use Case: Base Class That Shouldn't Be Created Directly
            Imagine you’re creating a base class for employees. You don’t want anyone to create 
            a generic Employee object — only specific types like Manager or Engineer.

            * Employee constructor called. Name: Alice
            Manager constructor called.
            Employee name: Alice

            The constructor of Employee is marked protected, so:

            You cannot create an Employee directly from Main() → this line will fail:
            Employee emp = new Employee("John"); // ❌ Compile-time error
            But you can subclass it (e.g., Manager) and call it from there.

            Why Use a Protected Constructor?
            To enforce abstraction: the base class is not meant to be used on its own.

            To force specialization: you require subclasses (e.g., Manager, Engineer) to define how the base class is used.

     */
}
