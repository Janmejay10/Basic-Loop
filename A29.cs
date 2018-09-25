using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char c = Convert.ToChar(Console.ReadLine());
            switch(c)
            {
                case 'a': Console.WriteLine("case a");
                    break;
                case 'e': Console.WriteLine("case e");
                    break;
                case 'i': Console.WriteLine("case i");
                    break;
                case 'o':
                    Console.WriteLine("case o");
                    break;
                case 'u':
                    Console.WriteLine("case u");
                    break;
                default: Console.WriteLine("it is a consonent");
                    break;
            }
            Console.Read();
        }
    }
}
