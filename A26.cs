using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A26
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter a number");
            i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 10: Console.WriteLine("it is 10");
                break;
                case 20: Console.WriteLine("it is 20");
                break;
                case 30: Console.WriteLine("it is 30");
                break;
                default: Console.WriteLine("out of range number");
                break;
            }
            Console.Read();
        }
    }
}
