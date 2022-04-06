using System;
using System.Collections.Generic;
using System.Text;

namespace singleAndMultidimensional_array
{
    class multidimensional
    {
        public void multi()
        {
            int i, j;
            string[,] books = new string[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\n Enter book name for {0}.Row and {1}.column:\t", i + 1, j + 1);
                    books[i, j] = Console.ReadLine();

                }
            }
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("all the element of books array is :\n\n");
            Console.WriteLine("\t1\t2\t3\n\n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}.\t", i + 1);
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", books[i, j]);

                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n=====================");
            Console.ReadLine();

        }
    }
}
