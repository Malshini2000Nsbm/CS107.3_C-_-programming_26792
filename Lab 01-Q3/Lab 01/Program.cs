using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, sum;

            Console.WriteLine("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("The summation is " + sum);

            Console.ReadKey();
        }
    }
}
