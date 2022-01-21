using OOPsConcept.Encapsulation;
using OOPsConcept.Inheritance;
using OOPsConcept.Polymorphism.MethodOverloading;
using OOPsConcept.Polymorphism.MethodOverRiding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
     class Program
    {
        static void Main(string[] args)
        {
            //Dog pug = new Dog();    //pug Object declare
            //pug.Age = 10;           // object information declare
            //pug.breed = "pug";
            //pug.color = "cream";
            //pug.size = 23;
            //Console.WriteLine("Pug Details:Age:{0},Breed:{1},Color:{2},size:{3}",pug.Age,pug.breed,pug.color,pug.size);

            //Dog julee = new Dog();    //pug Object declare
            //julee.Age = 20;           // object information declare
            //julee.breed = "julee";
            //julee.color = "white";
            //julee.size = 13;
            //Console.WriteLine("Julee Details:Age:{0},Breed:{1},Color:{2},size:{3}", julee.Age, julee.breed, julee.color, julee.size);

            //Dog puppy = new Dog();    //pug Object declare
            //puppy.Age = 30;           // object information declare
            //puppy.breed = "puppy";
            //puppy.color = "brown";
            //puppy.size = 33;
            //Console.WriteLine("Puppy Details:Age:{0},Breed:{1},Color:{2},size:{3}", puppy.Age, puppy.breed, puppy.color, puppy.size);

            Console.WriteLine("************Inheritance**************");
            Vehicle vehicle = new Vehicle();


            Car car = new Car();
            car.brand = "BMW";
            car.honk();
            car.Start();

            Console.WriteLine("************Method Overloading**************");
            Addition addition = new Addition();
            addition.SumOfNumbers(10, 20);  //method arguments
            addition.SumOfNumbers(10,20,30);
            addition.SumOfNumbers(10, 1.5, 20);
            addition.SumOfNumbers(1.23, 10, 20);

            Console.WriteLine("************Method OverRiding**************");
            Employee employee = new Employee();
            employee.GetSalary();
            employee.EmployeeDetails();
            PartTimeEmployee partTime = new PartTimeEmployee();
            partTime.GetSalary();

            Console.WriteLine("************Encapsulation**************");
            Account account = new Account();
            account.SetBalance(1000);
            account.GetBalance();
            Console.ReadLine();
        }
    }
}
