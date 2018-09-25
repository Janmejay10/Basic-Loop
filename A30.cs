using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'a':
                    Console.WriteLine("case a");
                    break;
                case 'e':
                    Console.WriteLine("case e");
                    break;
                case 'p':
                    Console.WriteLine("case p");
                    break;                              
             //   case 112:
              //      Console.WriteLine("case o");  // this applied only in java not c#
              //      break;                         
                
            }
            Console.Read();
        }
    }
}
