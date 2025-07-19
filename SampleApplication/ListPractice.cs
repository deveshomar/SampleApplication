using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class EmployeeDataValue
    {
        
        public int Id { get; set; }
        public string Name { get; set; }        
        public string FirstName { get; set; }   = string.Empty;
        public string LastName { get; set; }  
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public string Email { get; set; } = string.Empty;   
        public string Phone { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } 
        public string EmailAddress { get; set; } = string.Empty;
        public string Address { get; set; } 
        public string City { get; set; } = string.Empty;




        public EmployeeDataValue  GetEmpLoyee()
        {
            EmployeeDataValue obj = new EmployeeDataValue();
            obj.Id = 789;
            obj.Phone = "1234567";
            obj.DateOfBirth = DateTime.Now.AddYears(-30);
            obj.FirstName = "Devesh";
            obj.LastName = "Omar";
            obj.Address = "G.89 ,Noida";
            obj.City = "Noida";

            return obj;

           

        }

        public List<EmployeeDataValue>  GetEmpLoyeeList()
        {

            List<EmployeeDataValue> list = new List<EmployeeDataValue>();
            EmployeeDataValue obj = new EmployeeDataValue();
            obj.Id = 789;
            obj.Phone = "1234567";
            obj.DateOfBirth = DateTime.Now.AddYears(-30);
            obj.FirstName = "Devesh";
            obj.LastName = "Omar";
            obj.Address = "G.89 ,Noida";
            obj.City = "Noida";
            list.Add(obj);
            EmployeeDataValue obj1 = new EmployeeDataValue();
            obj1.Id = 4567;
            obj1.Phone = "677789";
            obj1.DateOfBirth = DateTime.Now.AddYears(-30);
            obj1.FirstName = "Raju";
            obj1.LastName = "Sharma";
            obj1.Address = "G.89 ,hyd";
            obj1.City = "hyd";

            list.Add(obj1);

            EmployeeDataValue obj2 = new EmployeeDataValue();
            obj2.Id = 123450000;
            obj2.Phone = "677789";
            obj2.DateOfBirth = DateTime.Now.AddYears(-20);
            obj2.FirstName = "Pankaj";
            obj2.LastName = "Sharma 345";
            obj2.Address = "G.89 ,hyd";
            obj2.City = "Delhi";
            list.Add(obj2);

            return list;



        }

        public EmployeeDataValue SearchEmp(List<EmployeeDataValue> elist, int id)
        {

            EmployeeDataValue evalue= elist.FirstOrDefault(edata => edata.Id == id);
            return evalue;
        }
    }
}


/*
 
// hi Devesh 
EmployeeDataValue obj1 = new EmployeeDataValue();
EmployeeDataValue obj = new EmployeeDataValue();

obj1=obj.GetEmpLoyee();

Console.WriteLine("Name is -" + obj1.FirstName);
Console.WriteLine("Last name is -" + obj1.LastName);

var emplist= obj.GetEmpLoyeeList();

foreach (var emp in emplist)
{
    Console.WriteLine("Emp NAMES are " + emp.FirstName  +" City is " + emp.City);
   
}

Console.WriteLine("===============================");

var empdata= obj.SearchEmp(emplist, 123450000);
Console.WriteLine("seared data details are " + empdata.FirstName + " City is " + empdata.City);




 */