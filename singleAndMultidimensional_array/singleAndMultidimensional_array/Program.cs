using System;

namespace singleAndMultidimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            multidimensional Multi_array = new multidimensional();
            single_array single = new single_array();
            char ch;
            Console.WriteLine("------------------------------WELCOME--------------------------------");
            do
            {
                Console.WriteLine("\t1.Multidimensional Array");
                Console.WriteLine("\t2.singledimensional Array\n");
            lab:
                Console.Write("Enter the 1 or 2 program : ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Multi_array.multi();
                        break;
                    case 2:
                        single.singleAarray();
                        break;

                    default:
                        Console.WriteLine("Enter the valid input:");
                        goto lab;
                }
                Console.WriteLine("Do you want run again : Y/N ");
                ch = Convert.ToChar(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
           
        }
    }
}
