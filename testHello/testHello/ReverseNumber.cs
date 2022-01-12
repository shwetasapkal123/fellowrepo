using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testHello
{
     class ReverseNumber
    {
        public static void findReverseNumber()
        {
            Console.WriteLine("Please enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine("After reverse : " + reverse);
        }
           
    }
}
