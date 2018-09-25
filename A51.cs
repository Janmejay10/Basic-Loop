using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A51
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size you want");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++ )
            {
                if(i == 1 || i == num)
                {
                    for(int j = 1; j <= num; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for(int j = 1; j <= (num-2); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
