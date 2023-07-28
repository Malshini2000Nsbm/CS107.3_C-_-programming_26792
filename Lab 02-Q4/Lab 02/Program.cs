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
            int no;
            Console.WriteLine("Enter whole number: ");
            
            no = int.Parse(Console.ReadLine());

            if (no > 70)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            Console.ReadLine();
        }
    }
}
