using System;

namespace starshapoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i < 5; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
