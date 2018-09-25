using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A20
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(" ");
                }
                if(i % 2 == 0)
                {
                    for (int j = ((2 * i) - 1); j >= 1 ; j--)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for(int j = 1; j <= ((2 * i) - 1); j++)
                    {
                        Console.Write(j);
                    }
                }

                
                Console.WriteLine();

            }
            Console.Read();


        }
    }
}
