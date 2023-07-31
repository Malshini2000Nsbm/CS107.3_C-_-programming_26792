using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            
                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                ArrayOperations arrayOps = new ArrayOperations();

                int min = arrayOps.FindMinimum(array);
                int max = arrayOps.FindMaximum(array);
                double average = arrayOps.FindAverage(array);
                int[] reversedArray = arrayOps.ReverseArray(array);

                Console.WriteLine($"Minimum value: {min}");
                Console.WriteLine($"Maximum value: {max}");
                Console.WriteLine($"Average value: {average}");
                Console.WriteLine("Reversed array:");
                foreach (int value in reversedArray)
                {
                    Console.Write(value + " ");
                }
            
        }
    }
}
