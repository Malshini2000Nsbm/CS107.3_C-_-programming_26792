using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                MyClass myObject = new MyClass();

                // Attempt to access the private method.
                // This will cause a compile-time error since private methods cannot be accessed from outside the class.
                myObject.SayHello();
            }
        }
    }
}
