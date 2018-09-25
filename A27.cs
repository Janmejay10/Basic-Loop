using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A27
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter a number");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:

                    Console.WriteLine("number is odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
             
                    Console.WriteLine("number is even");
                    break;
                
                default:
                    Console.WriteLine("number is out of range of 10");
                    break;
            }
            Console.Read();
        }
    }
}
