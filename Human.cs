using System;
using System.Collections.Generic;
using System.Text;

//Inheritance and encapsulation demonstration
//See https://is.gd/OC7v7H
namespace BasicCS
{
    //In this case, 'Human' inherits the properties of 'Animal' class, in other words Human is an Animal
    //but Animal is not a human since inheritance is a one way relationship wherein
    //the left class 'inherits' all properties of the left class
    public class Human : Animal
    {
        //Encapsulation example
        //For definition see https://is.gd/IL6tUB
        public Vehicle Vehicle { get; set; }
        public string Work { get; set; }

        //Default constructos are special than other constructors since if
        //the Human() default constructor is called the Animal() default constructor is
        //also invoked
        //e.g. Since Human inherits the properties Name & Age, and if you refer to the Animal default
        //constructor you will see that Name is set to an empty string and Age is set to a value of 0
        //so if Human() is invoked, the properties will be set along with additional statements
        public Human()
        {
            Vehicle = new Vehicle();
            Work = "None";
        }
    }
}
