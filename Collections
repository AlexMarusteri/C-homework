using System;
using System.Collections.Generic;

class Exercise21
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int EmployeeAge { get; set; }

        public override string ToString()
        {
            return $"ID: {EmployeeId}, Name: {EmployeeFirstName} {EmployeeLastName}, Age: {EmployeeAge}";
        }
    }

    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee { EmployeeId = 1, EmployeeFirstName = "Alice", EmployeeLastName = "Smith", EmployeeAge = 30 });
        employees.Add(new Employee { EmployeeId = 2, EmployeeFirstName = "Bob", EmployeeLastName = "Johnson", EmployeeAge = 45 });

        Console.WriteLine("Employees after adding:");
        DisplayEmployees(employees);

        employees.RemoveAll(e => e.EmployeeId == 1);

        Console.WriteLine("Employees after removing ID = 1:");
        DisplayEmployees(employees);
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}
