using System;

namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char yes, ch;
            do
            {
                Console.WriteLine("Enter the any single letter");
                ch = Convert.ToChar(Console.ReadLine());
                if ((ch == 'a') || (ch == 'A') || (ch == 'e') || (ch == 'E') || (ch == 'i') || (ch == 'I') || (ch == 'o') || (ch == 'O') || (ch == 'u') || (ch == 'U'))
                {
                    Console.WriteLine("{0} this word  is vowel", ch);
                }
                else
                {
                    Console.WriteLine("{0}  This word is not vowel", ch);

                }
                Console.WriteLine("Do you want run again Y/N");
                yes = Convert.ToChar(Console.ReadLine());

            } while ((yes == 'y') || (yes == 'Y'));


        }
    }
}
