using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    //each word 1st letter has to start with uppercase=Pascal case 
    //Pascal will follow for classname and method name
     class SwapTwoNumber
    {
        public static void SwapingNumbers()
        {
           //Camel case for local variables and method parameter
           int firstnum,secondnum,temp=0;
            Console.WriteLine("Please enter first number");
            firstnum=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            secondnum=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before exchnaging values: first={0},second={1}", firstnum, secondnum);
            temp = firstnum;
            firstnum = secondnum;
            secondnum= temp;
            Console.WriteLine("After exchanging:first={0},second={1}", firstnum, secondnum);
        }
    }
}
