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
            int n, sum = 0;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of odd numbers from 1 to {n} is: " + sum);
            Console.ReadLine();

        }
    }
}
