using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter the number");
                int n = Int32.Parse(Console.ReadLine());
                sum_method(n);
                Console.WriteLine("\n\nDo you want run again Y/N");
                ch =Convert.ToChar(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
            static void sum_method(int n)
            {
                int sum = 0, m;
                while (n > 0)
                {
                    m = n % 10;
                    sum = sum + m;
                    n = n / 10;
                }
                
                Console.Write("Sum of value= " + sum);

            }
        
    }
}
