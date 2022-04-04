using System;

namespace numReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = null;
            try
            {
                int length = value.Length;
                Console.WriteLine(length);

                Console.ReadLine();
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }

            Console.ReadLine();
        }
    }
}
