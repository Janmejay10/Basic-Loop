using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = i > 50 ? 100 : 0;
            Console.WriteLine("second number is:" + j);
            Console.Read();
        }
    }
}
