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
    public interface InterFI1
    {
        void Show();
    }

    public interface InterFI2
    {
        void Display();
    }

    public class MyClass : InterFI1, InterFI2
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

    public interface InterfaceI1
    {
        void Print();
    }

    public interface InterfaceI2
    {
        void Print();
    }

    public class MyClassData : InterfaceI1, InterfaceI2
    {
        // Explicit implementation for I1.Print
        void InterfaceI1.Print()
        {
            Console.WriteLine("I1 Print method");
        }

        // Explicit implementation for I2.Print
        void InterfaceI2.Print()
        {
            Console.WriteLine("I2 Print method");
        }

        // Optional: public method to call either interface explicitly
        public void CallPrintMethods()
        {
            ((InterfaceI1)this).Print();
            ((InterfaceI2)this).Print();
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


/*
 
 


//
//{ 
//IReport objP = ReportGenerationFactory.CreateReport("HTML", "PDF Report..generation");
//objP.Generate();


//}

//IReport objP =  ReportGenerationFactory.CreateReport("PDF", "PDF Report..generation");
//objP.Generate();

//IReport objW = ReportGenerationFactory.CreateReport("Word", "Word Report..generation");
//objW.Generate();

//IReport objE = ReportGenerationFactory.CreateReport("EXCEL", "EXCEL Report..generation");
//objE.Generate();





//WordReport report = new WordReport("Monthly Sales Report");
//report.Generate();

//PdfReport pdf = new PdfReport("Monthly Sales Report");
//pdf.Generate();

//// Using the interface IReport to generate reports  
//IReport ireport = new WordReport("Monthly Sales Report");
//ireport.Generate();

//IReport ipdf = new PdfReport("Monthly Sales Report");
//ipdf.Generate();




//ReportService.PrintReport(pdf);
//ReportService.PrintReport(report); 
 */