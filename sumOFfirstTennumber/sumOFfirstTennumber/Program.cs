using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_natural_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to find the sum of first 10 natural numbers */
            int i, sum = 0;
            Console.WriteLine("The first 10 natural numbers");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write("{0} ", i);
            }
            Console.Write("\nThe Sum is : {0}", sum);

            Console.ReadKey();
        }
    }
}