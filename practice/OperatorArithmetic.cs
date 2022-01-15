using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
     class OperatorArithmetic
    {
       public static void operatorOperation()
        {
            int x, y,sum,sub,mul,modu;
            float div;
          
            Console.WriteLine("Enter first number ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            y=Convert.ToInt32(Console.ReadLine());

            sum = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
            modu = x % y;

            Console.WriteLine("Addition is=" + sum + "Subtraction is=" + sub + " multiplication is=" + mul + "Division is=" + div + "Reminder is=" + modu);
            
        }
       
       
    }
}
