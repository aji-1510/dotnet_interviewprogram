using System;

namespace tables
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                int n;
                Console.WriteLine("which table you want see");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(+i + "*" + n + "=" + (i * n));
                }
                Console.WriteLine("Do you want run again Y/N");
                ch = Convert.ToChar(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
}
