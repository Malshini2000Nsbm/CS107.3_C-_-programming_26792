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
            Console.Write("Enter the Kilometer value: ");
            double kilometer = double.Parse(Console.ReadLine());

            ConvertValues objConverteValues = new ConvertValues();
            double meterValue = objConverteValues.kilometerTOmeter(kilometer);
            Console.WriteLine($"{kilometer} kilometers is equal to {meterValue} meters.");
        }
    }
}
