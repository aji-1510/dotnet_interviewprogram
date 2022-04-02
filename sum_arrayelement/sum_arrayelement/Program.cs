using System;

namespace sum_arrayelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,n;
            Console.WriteLine("enter the n value");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("\n");
            for (int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine("\n");

            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("totel value of array elements : " + sum);
        }
    }
}
