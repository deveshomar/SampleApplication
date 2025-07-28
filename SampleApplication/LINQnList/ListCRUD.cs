using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.LINQnList
{

    public class EmployeeClassData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public EmployeeClassData(int id, string name, string position)
        {
            Id = id;
            Name = name;
            Position = position;
        }
    }
    internal class EmployeeRepository
    {
        private List<EmployeeClassData> _employees;
        public EmployeeRepository()
        {
            _employees = new List<EmployeeClassData>();
        }

        // Create operation
        public void AddEmployee(EmployeeClassData employee)
        {
            _employees.Add(employee);
        }

        // Read operation
        public List<EmployeeClassData> GetAllEmployees()
        {
            return _employees;
        }

        public EmployeeClassData GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        // Update operation
        public bool UpdateEmployee(int id, string newName, string newPosition)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                employee.Name = newName;
                employee.Position = newPosition;
                return true;
            }
            return false;
        }

        // Delete operation
        public bool DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
                return true;
            }
            return false;
        }
    }
}
/*
 AddEmployee: Adds a new employee to the list.
GetAllEmployees: Returns all employees.
GetEmployeeById: Returns an employee by ID.
UpdateEmployee: Updates an employee's name and position by ID.
DeleteEmployee: Deletes an employee by ID.

var repository = new EmployeeRepository();

// Add employees
repository.AddEmployee(new EmployeeClassData(1, "Devesh omar", "Developer"));
repository.AddEmployee(new EmployeeClassData(2, "Hillary ", "Architech"));
repository.AddEmployee(new EmployeeClassData(3, "Vinu ", "Manager"));
repository.AddEmployee(new EmployeeClassData(4, "Pankaj ", "Sr. Manager"));

// Read employees
Console.WriteLine("Employees after creation:");
foreach (var employee in repository.GetAllEmployees())
{
    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}");
}


//update

// Update an employee
repository.UpdateEmployee(2, "Kumar Devesh ", "Senior Product ");
Console.WriteLine("\nEmployees after update:");
foreach (var employee in repository.GetAllEmployees())
{
    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}");
}

// delete
// Delete an employee
repository.DeleteEmployee(1);
Console.WriteLine("\nEmployees after deletion:");
foreach (var employee in repository.GetAllEmployees())
{
    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}");
}

Console.ReadKey();
 */