using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{

    public class Person
    {
        public Person()
        {
            Console.WriteLine("Inside person"); 
            //DB class  
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Departmant { get; set; }
        public decimal Salry { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
    public class EmployeeClass : Person
    {
        public EmployeeClass()
        {
            Console.WriteLine("Inside EmployeeClass");
        }
        public void Meetings()
        {

        }
        public void Getwork()
        {
        }
    }

    public class HREmp : EmployeeClass
    {
        public HREmp()
        {
            Calculator obj = new Calculator();

            Console.WriteLine("Inside HREmp");
        }
        public int  GetCalculateSalary ()
        {

            string str = "hi";
            return 5555;
            // we have to add somelogic
        }

        public void AttandanceCheck()
        {
            Console.WriteLine("do AttandanceCheck work");
        }
    }
    public class Visitor: Person
    {
        public Visitor()
        {
            Console.WriteLine("Inside HREmp");
        }
        public int VisitorID { get; set; }

        public void Getwork()
        { 
        
        }
    }
}
/*
 
void ExecutePerson()
{
    Person obj= new Person();

    EmployeeClass emp = new EmployeeClass();

    HREmp heobj = new HREmp();
    int salary=   heobj.GetCalculateSalary();
    Console.WriteLine("Salary-" + salary.ToString());
    heobj.AttandanceCheck();

}


 void ExecuteEmp()
{
EmployeeClass obj;
EmployeeClass obj1;
EmployeeClass obj2;
EmployeeClass obj3;
obj = new EmployeeClass();// full
//CLR--Garbage collector  - do work  automatically..
//we can do forcefully........
obj.ID = 12345;
obj.Name = "Raja";

Console.WriteLine("OBJ ID-" + obj.ID);
Console.WriteLine("OBJ Name-" + obj.Name);

obj3 = obj;

Console.WriteLine("OBJ3 ID-" + obj3.ID);
Console.WriteLine("OBJ3 Name-" + obj3.Name);

obj.ID = 9999;
Console.WriteLine("After update....9999");
Console.WriteLine("OBJ ID-" + obj.ID);
Console.WriteLine("OBJ3 ID-" + obj3.ID);
}

 */