using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Polymorphism.MethodOverRiding
{
     class Employee
    {
        public string name;
        public double salary;

        public void EmployeeDetails()
        {
            Console.WriteLine("Name:Shweta");
        }
        public void GetSalary()
        {
            Console.WriteLine("Parent Salary:500");
        }
    }
}
