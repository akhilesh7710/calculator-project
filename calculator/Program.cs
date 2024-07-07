using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;
            Console.WriteLine("wellcome to the calculator side");
            Console.WriteLine("please enter the number.");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the second number.");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what type of operation would you like.");
            Console.WriteLine("please enter a for addition, s for subtraction, m for multiplication or any other key for division.");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result =num1+ num2;
            }
            else if(answer == "s")
            {
                result =num1 - num2;
            }
            else if(answer =="m")
            {
                result =num1 * num2;
            }
            else
            {
                result=num1 / num2;
            }

            Console.WriteLine("the result is " + result);
            Console.WriteLine("Thank you for using calculator");

            Console.ReadLine();
        }
    }
}
