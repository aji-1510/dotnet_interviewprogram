using System;

namespace checkUncheck
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                sbyte num1 = 10, num2 = -24, result;
                try
                {
                    unchecked
                    {
                        result = (sbyte)(num1 * num2);
                        Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                    }
                    checked
                    {
                        result = (sbyte)(num1 * num2);
                        Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                    }
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine(oe.Message);
                }

                Console.ReadKey();
                Console.WriteLine("Do you want run again Y/N");
                ch = Convert.ToChar(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        } 
    }
}
