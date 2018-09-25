using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A8
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("enter two nos.");
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is:" + c);
            Console.Read();
        }
    }
}
