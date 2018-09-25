using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A25
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("enter the numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (b < a && b > c)
            {
                Console.WriteLine("b is the middle number");
            }
            else if (c < a && c > b)
            {
                Console.WriteLine("c is the middle number");
            }
            else
            {
                Console.WriteLine("a is the middle number");
            }
            Console.ReadKey();
        }
    }
}
