using System;

namespace oddandEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("enter the number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if((num1%2)==0)
            {
                Console.WriteLine("this is even number");

            }
            else
            {
                Console.WriteLine("this is odd number");
            }

        }
    }
}
