using System;
using System.Collections.Generic;
using System.Text;

namespace singleAndMultidimensional_array
{
    class single_array
    {
        public void singleAarray()
        {
            string[] books = new string[5];
            books[0] = "c#";
            books[1] = "Java";
            books[2] = "vb.net";
            books[3] = "c++";
            books[4] = "angular";

            Console.WriteLine("All the element of books array is :\n\n");
            int i = 0;
            Console.WriteLine("\t1\t2\t3\t4\t5\n\n\t");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", books[i]);
            }
            Console.ReadLine();

        }
    }
}
