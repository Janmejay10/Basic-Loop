using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter your name again");
            string s2 = Console.ReadLine();
            if(s1 == s2)
            {
                Console.WriteLine("confirmed");
            }
            else
            {
                Console.WriteLine("pls check again");
            }
            Console.ReadLine();
        }
    }
}
