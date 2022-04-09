using System;

namespace all_print_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string words;
            Console.WriteLine("---------------------Enter the your name-------------------");
            words = Console.ReadLine();
            for (int i = 1; i < words.Length; i++)
            {
                for (int start = 0; start <= words.Length - i; start++)
                {
                    string substr = words.Substring(start, i);
                    Console.WriteLine(substr);
                }
            }
        }
    }
}
