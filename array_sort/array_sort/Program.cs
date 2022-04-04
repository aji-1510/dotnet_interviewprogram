using System;

namespace array_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------your array elements--------------");
            Console.WriteLine("\n");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            Array.Sort(arr);
            Console.WriteLine("--------------sort array---------------");
            Console.WriteLine("\n");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }

        }
    }
}
