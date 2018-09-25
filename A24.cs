using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A24
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
            Console.WriteLine("enter the numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if(b>a && b>c)
            {
                Console.WriteLine("b is the largest");
            }
            else if(c>a && c>b)
            {
                Console.WriteLine("c is the largest");
            }
            else
            {
                Console.WriteLine("a is the largest");
            }
            Console.ReadKey();
        }
    }
}
