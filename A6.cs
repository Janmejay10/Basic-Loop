using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A7
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter two nos.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is:" + c);
            Console.Read();
        }
    }
}
