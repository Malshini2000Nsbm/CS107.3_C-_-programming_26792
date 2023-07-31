using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                Console.Write("Enter the size of the arrays: ");
                int size = int.Parse(Console.ReadLine());

                int[] array1 = new int[size];
                int[] array2 = new int[size];

                Console.WriteLine("Enter values for the first array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    array1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter values for the second array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    array2[i] = int.Parse(Console.ReadLine());
                }

                
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i] + array2[i];
                }
                Console.WriteLine("Scalar Sum: " + scalarSum);

               
                int[] vectorSum = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorSum[i] = array1[i] + array2[i];
                }
                Console.WriteLine("Vector Sum:");
                PrintArray(vectorSum);

                
                int[] vectorProduct = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorProduct[i] = array1[i] * array2[i];
                }
                Console.WriteLine("Vector Product:");
                PrintArray(vectorProduct);

                
                int[] scalarProductArray = new int[size];
                int scalarProductSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarProductArray[i] = array1[i] * array2[i];
                    scalarProductSum += scalarProductArray[i];
                }
                Console.WriteLine("Scalar Product:");
                PrintArray(scalarProductArray);
                Console.WriteLine("Scalar Product Sum: " + scalarProductSum);
            }

            static void PrintArray(int[] arr)
            {
                foreach (int element in arr)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }

    }

