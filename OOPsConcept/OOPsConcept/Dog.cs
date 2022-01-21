using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    class Dog
    {
        //charactoristics or variable of entity
        public string breed, color;
        public int Age,size;

        //Actions or behaviour or methods of entity
        public void Sleep()
        {
            Console.WriteLine("Dog sleep");
        }

        public void Run()
        {
            Console.WriteLine("Dog Run");
        }
    }
}
