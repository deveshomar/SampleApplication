using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
    internal class LinqCoding
    {

        // 1. Filtering
        static void FilterByDepartment(List<EmployeeData> employees)
        {
            var hrEmployees = employees.Where(e => e.Department == "HR");

            Console.WriteLine("Employees in HR:");
            foreach (var emp in hrEmployees)
                Console.WriteLine($"{emp.Name} ({emp.Department})");
        }

        // 2. Projection
        static void ProjectEmployeeNames(List<EmployeeData> employees)
        {
            var names = employees.Select(e => e.Name);

            Console.WriteLine("\nEmployee Names:");
            foreach (var name in names)
                Console.WriteLine(name);
        }

        // 3. Sorting
        static void SortByAge(List<EmployeeData> employees)
        {
            var sorted = employees.OrderBy(e => e.Age);

            Console.WriteLine("\nEmployees sorted by Age:");
            foreach (var emp in sorted)
                Console.WriteLine($"{emp.Name} - {emp.Age}");
        }

        // 4. Grouping
        static void GroupByDepartment(List<EmployeeData> employees)
        {
            var grouped = employees.GroupBy(e => e.Department);

            Console.WriteLine("\nEmployees grouped by Department:");
            foreach (var group in grouped)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var emp in group)
                    Console.WriteLine($" - {emp.Name}");
            }
        }

        // 5. Aggregation
        static void AggregateOperations(List<EmployeeData> employees)
        {
            var total = employees.Sum(e => e.Salary);
            var avg = employees.Average(e => e.Salary);
            var max = employees.Max(e => e.Salary);
            var min = employees.Min(e => e.Salary);

            Console.WriteLine($"\nSalary Stats:");
            Console.WriteLine($"Total: {total}, Average: {avg}, Max: {max}, Min: {min}");
        }

        // 6. Set Operations
        static void SetOperations(List<EmployeeData> employees)
        {
            var names = employees.Select(e => e.Name);
            var distinctDepartments = employees.Select(e => e.Department).Distinct();

            Console.WriteLine("\nDistinct Departments:");
            foreach (var dept in distinctDepartments)
                Console.WriteLine(dept);
        }

        // 7. Element Operations
        static void ElementOperations(List<EmployeeData> employees)
        {
            var firstIT = employees.First(e => e.Department == "IT");
            var singleHR = employees.SingleOrDefault(e => e.Name == "Eva");

            Console.WriteLine($"\nFirst IT Employee: {firstIT.Name}");
            Console.WriteLine($"Single HR Employee (Eva): {singleHR?.Name}");
        }

        

        public static List<EmployeeData> GetEmployees()
        {
            return new List<EmployeeData>
    {
        new EmployeeData { Id = 1, Name = "Alice", Department = "HR", Age = 28, Salary = 50000 },
        new EmployeeData { Id = 2, Name = "Bob", Department = "IT", Age = 32, Salary = 70000 },
        new EmployeeData { Id = 3, Name = "Charlie", Department = "IT", Age = 25, Salary = 65000 },
        new EmployeeData { Id = 4, Name = "David", Department = "Finance", Age = 45, Salary = 85000 },
        new EmployeeData { Id = 5, Name = "Eva", Department = "HR", Age = 30, Salary = 52000 },
        new EmployeeData { Id = 6, Name = "Frank", Department = "IT", Age = 29, Salary = 60000 },
    };
        }
    }
}

/*
 List<Employee> employees = GetEmployees();

        FilterByDepartment(employees);
        ProjectEmployeeNames(employees);
        SortByAge(employees);
        GroupByDepartment(employees);
        AggregateOperations(employees);
        SetOperations(employees);
        ElementOperations(employees);
 */