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
            double radius, area;
            Console.WriteLine("Enter the radius: ");

            radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;

            Console.WriteLine("area is " + area);

            Console.ReadKey();
        }
    }
}
