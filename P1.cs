using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entry point");
            while (i <= 5)
            {
                Console.WriteLine("loop:" + i + "starts");

                if (i == 4)
                {
                    Console.WriteLine("ending the loop right now");
                    break;
                }
                Console.WriteLine("loop:" + i + " ends");
                i++;

            }
            Console.WriteLine("exit point");
            Console.Read();
        }
    }
}
