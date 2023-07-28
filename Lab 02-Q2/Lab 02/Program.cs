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
            double height, width;

            Console.WriteLine("Enter the height: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            width = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("The area is " + area);

            double perimeter = (2 * width) + (2 * height);

            Console.WriteLine("The perimeter is " + perimeter);

            Console.ReadLine();
        }
    }
}
