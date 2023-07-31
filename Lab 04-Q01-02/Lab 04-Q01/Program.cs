using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues objConverteValues = new ConvertValues();

            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            objConverteValues.kilometerTOmeter(kilometers);
        }
    }
}
