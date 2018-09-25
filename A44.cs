using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A44
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i <= 5)
            {
                Console.WriteLine("while loop" + i + "starts");
                for (int j = 10; j <= 13; j++)
                {
                    Console.WriteLine("for loop" + j + "starts");
                    Console.WriteLine("for loop" + j + "ends");
                }
                Console.WriteLine("while loop" + i + "ends");
                i++;
            }
            Console.Read();
        }
    }
}
