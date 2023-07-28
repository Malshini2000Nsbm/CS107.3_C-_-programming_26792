using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Console.WriteLine("Enter the radius: ");
            radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The perimeter is " + perimeter);

            double area = Math.PI * radius * radius;

            Console.WriteLine($"area:{area}");

            Console.ReadLine();
        }
    }
}
