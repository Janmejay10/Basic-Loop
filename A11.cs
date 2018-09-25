using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A11
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter your no.");
            a = Convert.ToInt32(Console.ReadLine());
            
            switch(a)
            {
                case 10 : Console.WriteLine("it is under 10"); break;
                case 20 : Console.WriteLine("it is above 10"); break;
                case 30 : Console.WriteLine("it is above 20"); break;

            }
        }
    }
}
