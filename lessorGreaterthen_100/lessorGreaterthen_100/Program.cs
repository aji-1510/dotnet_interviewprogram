using System;

namespace lessorGreaterthen_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Enter the first number (<100): ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number (>200): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200));

            Console.ReadKey();
        }
    }
}
