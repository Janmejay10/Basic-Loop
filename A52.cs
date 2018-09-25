using System;

namespace ConsoleApp2
{
    class A52
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base size of A");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = a - 1; i >= 0; i--)
            {
                for(int j = 1; j < 4; j++ )
                {
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
