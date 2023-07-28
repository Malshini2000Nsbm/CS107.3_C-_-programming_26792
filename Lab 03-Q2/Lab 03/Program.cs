using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            int i, len, vowels = 0, constent = 0;
            Console.WriteLine("Enter the string: ");
            name = Console.ReadLine();
            len = name.Length;
            for (i = 0; i < len; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' ||
                name[i] == 'u' || name[i] == 'A' || name[i] == 'E' || name[i]== 'I' ||
                name[i] == 'O' || name[i] == 'U')
                {
                    vowels++;
                }
                else
                {
                    constent++;
                }


 }
            Console.WriteLine("Vowels in the string: {0}", vowels);
            Console.ReadLine();

        }
    }
}
