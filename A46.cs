using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A46
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entry point");
            Console.WriteLine("enter a number");
            int i = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("do-while loop" + i + "starts");
                i++;
            }
            while (i <= 5);
            Console.WriteLine("exit point");
            Console.Read();


        }
    }
}
