//See https://is.gd/cQIbQQ
//This part is the directives it is started with the 'using' keyword. Other examples in other languages are: 
//C/C++: #include <stdio.h>
//Java : import java.util.Scanner
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCS
{
    //Class declaration See https://is.gd/bMx45I
    //For now we used 'public' as the access modifier but for real projects
    //we should consider using 'internal' or 'protected internal' if we want
    //this class to be used within the project
    //See https://is.gd/f3e7WR
    public class Animal
    {
        //Properties or attributes

        //Format: data_type variable_name; Example below

        //data_type could be int, double, char or string
        //variable_name should follow .NET convention. Properties should start with a capital letter, one word, and no underscores. See https://is.gd/H6DOpM

        //Note that the expression '{ get; set;}' acts as the class' accessors.
        //See https://is.gd/hrUxUL
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor
        //Note there is no need for destructor since .NET has automatic garbage collection. See https://is.gd/k7uWoT
        public Animal()
        {
            Name = "Animal";
            Age = 0;
        }
    }
}
