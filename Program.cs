using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 5; a++ )
            {
                
                for (int b = 1; b <= a; b++ )
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }
    }
}
