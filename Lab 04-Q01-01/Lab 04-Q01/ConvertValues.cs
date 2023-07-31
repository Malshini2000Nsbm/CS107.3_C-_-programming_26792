using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Q01
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            double km;

            Console.WriteLine("Enter the km value: ");
            km= double.Parse(Console.ReadLine());

            double cm = km * 100000;

            Console.WriteLine("cm value is: " + cm);
            Console.ReadKey();
        }
    }
}
