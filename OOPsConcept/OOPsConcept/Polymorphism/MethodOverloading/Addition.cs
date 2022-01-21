using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Polymorphism.MethodOverloading
{
    class Addition
    {
        //Method Overloading can be represented in diff ways
        public void SumOfNumbers(int a,int b)   //1.number of parameter here two parameters a,b
        {
            int c= a+b;
            Console.WriteLine("Sum:"+c);
        }
        public void SumOfNumbers(int a,int b, int d)// here three parameter a,b,c
        {
            int c= a+b+d;
            Console.WriteLine("Sum of three parameter is:" + c);
        }
        public void SumOfNumbers(int b, double a, int d) // 2.datatypes of parameter: Here diff datatype is used float
        {
            double c = a+b+d;
            Console.WriteLine("sum of diff datatype used method is:" + c);
        }
        public void SumOfNumbers(double a, int b, int d) //3.order of parameter:Here float a used first instead of second 
        {
            double c = a+b+d;
            Console.WriteLine("Sum:" + c);
        }
    }
}
