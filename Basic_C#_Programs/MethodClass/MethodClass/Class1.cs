using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Class1
    {
          public void Method(int num1, int num2)  //two parameters
        {
            int result = num1 + 5;  // passing in parameter 1 for math equation
            Console.WriteLine(result);   //calling variable result to be displayed
            Console.WriteLine(num2);     
            Console.ReadLine();

        }

    }
}

//create a class. In that class, create a void method
//that takes two integers
//as parameters. Have the method do a math
//operation on the first integer
//and display the second integer to the screen.
//In the Main() method of the console app,
//instantiate the class
//Call the method in the class, passing in two numbers
//Call the method in the class, specifying the parameters by name.
