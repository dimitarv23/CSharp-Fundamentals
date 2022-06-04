using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal sal, string dep)
        {
            this.Name = name;
            this.Salary = sal;
            this.Department = dep;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    class Department
    {
        public Department(string name, decimal salary)
        {
            this.DepartmentName = name;
            this.AverageSalary = salary;
            this.PeopleInDepartment = 1;
        }

        public string DepartmentName { get; set; }
        public decimal AverageSalary { get; set; }
        public int PeopleInDepartment { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string employeeName = employeeInfo[0];
                decimal employeeSalary = decimal.Parse(employeeInfo[1]);
                string employeeDepartment = employeeInfo[2];

                Employee newEmployee = new Employee(employeeName, employeeSalary, employeeDepartment);
                employees.Add(newEmployee);

                if (departments.Exists(x => x.DepartmentName == employeeDepartment))
                {
                    //If the department already exists => sum the current employee salary and add one person to the number of people in the department
                    int indexOfDepartment = departments.FindIndex(x => x.DepartmentName == employeeDepartment);
                    departments[indexOfDepartment].AverageSalary += employeeSalary;
                    departments[indexOfDepartment].PeopleInDepartment++;
                }
                else
                {
                    //The department doesn't exist => add it
                    Department newDepartment = new Department(employeeDepartment, employeeSalary);
                    departments.Add(newDepartment);
                }
            }

            for (int i = 0; i < departments.Count; i++)
            {
                //For each department divide the sum of all salaries by the number of people in the department
                departments[i].AverageSalary /= departments[i].PeopleInDepartment;
            }

            //Sort the departments list by total salary and get the last element, which is the highest paid
            List<Department> sortedDepartments = departments.OrderBy(x => x.AverageSalary).ToList();
            Department highestPaid = sortedDepartments[sortedDepartments.Count - 1];
            //Create a new list of the employees in the highest paid department and sort it by salary in descending order
            List<Employee> highestPaidDepartmentEmployees = employees
                .Where(x => x.Department == highestPaid.DepartmentName)
                .OrderByDescending(x => x.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {highestPaid.DepartmentName}");

            foreach(Employee employee in highestPaidDepartmentEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
