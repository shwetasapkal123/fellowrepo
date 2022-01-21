using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Encapsulation
{
    class Account
    {
        public double balance=2000;

        public void SetBalance(double amount)
        {
            if (balance < 0)
            {
                Console.WriteLine("Please enter valid amount more than 100Rs");
            }
            else
            {
                balance = balance + amount;
            }
        }
        public void GetBalance()
        {
            Console.WriteLine("current balance"+balance);
        }
    }
}
