using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
  {
    static void Main(string[] args)
    {
        List<int> nums = new List<int> { 2, 4, 60, 80, 120, };
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing...");
            foreach (int num in nums)
            {
                int numberAns = num / numberOne;
                Console.WriteLine(numberOne + " divided by " + num + " equals " + numberAns);
            }   
            Console.ReadLine();
        }
        catch (FormatException ex)    
        {
            Console.WriteLine(ex.Message); //or writeline("Please type a whole number);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally       // always runs, logs info
        {
            Console.ReadLine();
        }
        Console.WriteLine("Try/Catch block complete, continuing with program execution");
        Console.ReadLine();
     }
  }
