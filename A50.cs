using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A50
    {
        static void Main(string[] args)
        {
            int count = 0, digit;
            Console.WriteLine("enter a number of your choice");
            int num = Convert.ToInt32(Console.ReadLine());
            for(; num != 0; num = num / 10)
            {
                digit = num % 10;
                count++;
            }
            Console.WriteLine(" number of digits are: " + count);
            Console.Read();
            
        }
    }
}
