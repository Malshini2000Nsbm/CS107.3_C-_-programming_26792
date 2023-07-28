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
            int x = 1;
            do
            {
                Console.WriteLine("enter number: ");
                x = int.Parse(Console.ReadLine());
            }
            while (x > 0);
            Console.ReadLine();
        }
    }
}
