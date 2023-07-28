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
            string name;
            string batch;

            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your batch: ");
            batch = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your batch is " + batch);

            Console.ReadKey();
        }
    }
}
