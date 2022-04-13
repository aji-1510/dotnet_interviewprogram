using System;

namespace calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,total;
            Console.WriteLine("------welcome -----------------");
            Console.WriteLine("\nEnter base number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter exponent number");
            num2 = Convert.ToInt32(Console.ReadLine());
            total = Convert.ToInt32(Math.Pow(num1, num2));
            Console.WriteLine("the base value {0} and exponet numbet {1} :{2}", num1, num2, total);
            Console.ReadKey();
        }
    }
}
