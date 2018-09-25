using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A37
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entry point");
            while(i<=50)
            {
                Console.WriteLine("loop:" + i + "starts");
                Console.WriteLine("loop:" + i + " ends");
                i += 10;
            }
            Console.WriteLine("exit point");
            Console.Read();
        }
    }
}
