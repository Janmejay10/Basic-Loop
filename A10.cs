using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A10
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter your no.");
            a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("your no. is even");
            }
            else
            {
                Console.WriteLine("your no.is odd");
            }
            Console.ReadKey();
        }
    }
}
