using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A36
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entery point");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("here the loop starts:" + i);
                if (i % 2 == 0)
                {
                    Console.WriteLine("if block starts");
                    return;
                    
                }
                
                Console.WriteLine("here the loop ends:" + i);

            }
            Console.WriteLine("exit point");
            Console.Read();

        }
    }
}
