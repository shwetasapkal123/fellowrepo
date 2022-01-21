using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Inheritance
{
    //base class (parent) Vehicle
     class Vehicle
    {
        //instance veriable
        public string brand = "Ford";   //Vehicle field

        //instance method
        public void honk()  //Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
