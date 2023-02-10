using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////Assinment for Optional Parameters /////////////
            Math1 math1 = new Math1();

            Console.WriteLine("Please enter two numbers, one at a time: ");
            int userInput = Convert.ToInt32(Console.ReadLine());   //converting input to int and storing as userInput
            Console.WriteLine("Enter a second number or hit enter to skip"); 
            string x = Console.ReadLine();  //storing user input as a string: x and displaying 
            int result;
            if (x == "") //if second user input is blank, use default parameter
            {
                result = math1.Method1(userInput);  //calling method and passing in userInput
                                                    //parameter and using default parameter
            }
            else
            {
                int userInput2 = Convert.ToInt32(x);  // if user inputs a number(variable x),
                                                      // it will be converted to to an integer
                result = math1.Method1(userInput, userInput2);   //calling method and passing
                                                                 //in both parameters (userInput and userInput2) 
            }
            Console.WriteLine(result);
            Console.ReadLine();

            //////////////////// Asignment for Main Method ////////////

            Math num = new Math();

            Console.WriteLine("Please enter a number to multiply by 15: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int number1 = num.Method(input);
            Console.WriteLine(number1);
            Console.ReadLine();

            Math num1 = new Math();

            Console.WriteLine("Please enter a decimal number to be added to 5: ");
            decimal input1 = Convert.ToDecimal(Console.ReadLine());
            decimal number2 = num1.Method(input1);
            Console.WriteLine(number2);
            Console.ReadLine();

            Math num2 = new Math();

            Console.WriteLine("Please enter a number to be divided by 2");
            string input2 = Console.ReadLine(); // storing user input
            int number3 = num2.Method(input2);  //storing method result & calling third method in Math class
            Console.WriteLine(number3);
            Console.ReadLine();


        }
    }
}
