using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A28
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter a character");
            c = Convert.ToChar(Console.ReadLine());
            int i = c;
            Console.WriteLine("its ASCII value is"   +  i);
            Console.Read();
        }
        
    }
}
