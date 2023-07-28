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
            int count = 10;
            int sum = 0;
            Console.WriteLine($" enter {count} numbers");
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            float avg = (float)sum / count;
            Console.WriteLine($"sum:{sum}");
            Console.WriteLine($"average:{avg}");
            Console.ReadLine();
        }
    }
}
