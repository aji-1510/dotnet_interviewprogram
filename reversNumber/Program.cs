using System;

namespace reversNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("enter the number of element");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("\n Enter the {0} number", n);
            for(i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("revers number");
           
            for(i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);

            }
        }
    }
}
