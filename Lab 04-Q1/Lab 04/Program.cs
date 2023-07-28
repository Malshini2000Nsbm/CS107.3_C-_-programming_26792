using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int sum = 0;
            while (count <= 10)
            {
                Console.WriteLine("Enter value for : " + count);
                string input = Console.ReadLine();
                int int_input = int.Parse(input);
                sum = sum + int_input;
                count++;
            }
            Console.WriteLine("The average is: " + (sum / 10));
            Console.ReadLine();
        }
    }
}
