using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entery point");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("here the loop starts:" + i);
                if (i == 5)
                {
                    Console.WriteLine("if block starts");
                    break;
                }
                Console.WriteLine("here the loop ends:" + i);

            }
            Console.WriteLine("exit point");
            Console.Read();

        }
    }
}
