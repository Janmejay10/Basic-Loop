using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("hashCode of given string is" + s.GetHashCode());
            Console.Read();
        }
    }
}
