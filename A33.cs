using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr second number");
            int j = Convert.ToInt32(Console.ReadLine());
            int k = i > 50 ? (j > 100 ? 1:2)  : (j < 100 ? 3:4);
            Console.WriteLine("third number will be:" + k);
            Console.Read();
        }
    }
}
