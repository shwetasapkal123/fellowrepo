using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Polymorphism.MethodOverRiding
{
     class PartTimeEmployee:Employee
    {
        public void GetSalary()
        {
            Console.WriteLine("Part time Salary:250");
        }
    }
}
