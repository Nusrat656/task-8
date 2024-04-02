using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Employee
    {
        private int employeeID;
        private string name;
        private string position;
        private double salary;

        public int EmployeeID
        {
            get { return employeeID; }
            private set { employeeID = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("NULL");
                }
            }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException("Error");
                }
            }
        }

        public Employee(int employeeID, string name, string position, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void UpdateSalary(double newSalary)
        {
            Salary = newSalary;
        }

        public void ChangePosition(string newPosition)
        {
            Position = newPosition;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
