using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());

                FindValues finder = new FindValues();
                double area = finder.FindArea(radius);
                double circumference = finder.FindCircumference(radius);

                Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
                Console.WriteLine($"The circumference of the circle with radius {radius} is: {circumference}");
            }
        }
    }
}
