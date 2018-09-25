using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A45
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entry point");
            while (i <= 5)
            {
                Console.WriteLine("outer whileloop:" + i++ + "starts");
                int j = 10;
                abc:
                while(j <= 13)
                {
                    Console.WriteLine("inner whileloop:" + j + "starts");
                    if (j == 11)
                    {
                        Console.WriteLine("neglecting the next statement");
                        j++;
                        goto abc;
                    }
                    Console.WriteLine("inner whileloop:" + j + "ends");
                    j++;
                }
                Console.WriteLine("outer whileloop:" + i + " ends");
                i++;

            }
            Console.WriteLine("exit point");
            Console.Read();
        }
    }
}
