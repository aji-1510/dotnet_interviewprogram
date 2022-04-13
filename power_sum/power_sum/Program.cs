using System;

namespace power_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program using withour math function
            /* int num1, num2, total = 1;
             Console.WriteLine("Enter base value");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a exponed value");
             num2 = Convert.ToInt32(Console.ReadLine());
             while (num2 >= 1)
             {
                 if (num2 > 0)
                 {
                     total = total * num1;
                 }
                 num2--;
             }
             Console.WriteLine("power value  {0}", total);*/

            //This program using math function


            int num1, num2, total;
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
