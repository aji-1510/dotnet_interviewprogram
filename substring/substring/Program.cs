using System;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "C# Program to List all Substrings in a given String";
            string find = words.Substring(23, 10);
            Console.WriteLine(words);
            Console.WriteLine("\n{0}", find);
            Console.ReadKey();
        }
    }
}
