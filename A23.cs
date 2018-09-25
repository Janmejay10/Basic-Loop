using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class A23
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char i;
            Console.WriteLine("enter your numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calculation required");
            i = Convert.ToChar(Console.ReadLine());
            if(i == '+')
            {
                c = a + b;
                Console.WriteLine(c);
            }
            else if(i == '-')
            {
                    c = a - b;
                    Console.WriteLine(c);
            }
            else if(i == '*')
            {
                c = a * b;
                Console.WriteLine(c);
            }
            else if(i == '/')
            {
                c = a / b;
                Console.WriteLine(c);
            }
            else if(i == '%')
            {
                c = a % b;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("entered character is invalid");
            }
            Console.Read();
        }
    }
}
