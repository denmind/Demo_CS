using System;

namespace BasicCS
{
    class Program
    {
        //See https://is.gd/4lAue8
        static void Main(string[] args)
        {
            //Call constructor to create a new object
            Animal A = new Animal();

            //Equivalent to printf()
            Console.WriteLine("Hello .NET!\n");

            //Note that '{0}' and '{1}' is bound to A.Name, A.Age accordingly
            //Equivalent in C as
            //printf("%d %d", name, age);
            Console.WriteLine("Before modifying:\n");
            Console.WriteLine("Hello my name is '{0}' and I am '{1}' years old!", A.Name, A.Age);

            //Use accessors to change the property values which we used are 'Name' and 'Age'
            A.Name = "Dog";
            A.Age = 10;

            Console.WriteLine("After modifying:\n");
            Console.WriteLine("Hello my name is '{0}' and I am '{1}' years old!\n\n", A.Name, A.Age);

            Vehicle car = new Vehicle();

            car.DisplayOperation();
        }
    }
}

//Please lookup just the fundamentals of C#
//Basic https://is.gd/f3Z8rK
//Better https://is.gd/CdE2vZ
//Pillars of OOP for .NET: https://is.gd/IL6tUB Top 4 sentences from the top, each pillar is italicized and provided with a brief description