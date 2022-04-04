using System;

namespace user_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                int a;
                Console.WriteLine("Welcome");
                a = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (a == 5 || a < 5)
                    {
                        Console.WriteLine("congratulation you have got an {0}", a);
                        Console.ReadLine();


                    }
                    else
                    {
                        throw (new OutOfStockException("OutofstockExcetion this program"));

                    }
                }
                catch (OutOfStockException oe)
                {
                    Console.WriteLine(oe.Message.ToString());
                    Console.ReadLine();
                }
                Console.WriteLine("Do you want run again Y/N");
                ch = Convert.ToChar(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
}
//creationg custom exception
public class OutOfStockException:Exception
{
    public OutOfStockException(string message) : base(message)
    {

    }


}
