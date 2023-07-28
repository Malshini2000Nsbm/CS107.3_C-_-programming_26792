using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, digit;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            //convert the number to a positive number
            number = Math.Abs(number);
            while (number > 0)
            {
                //get the last digit
                digit = number % 10;
                //add the digit to the sum
                sum = sum + digit;
                //remove the last digit from the number
                number = number / 10;
            }

            Console.WriteLine("the sum is= " + sum);
            Console.ReadLine();

        }
    }
}
