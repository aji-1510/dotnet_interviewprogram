using System;

namespace indexofarrayexception
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {


                int[] arr = new int[5];
                int n;
                try
                {
                    Console.WriteLine("enter the array element");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());

                    }
                  
                    Console.WriteLine("enter the any index value");
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("this array value {0}", arr[n]);
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex);
                }
                Console.ReadLine();
                Console.WriteLine("Do you want run again Y/N");
                ch = Convert.ToChar(Console.ReadLine());
             }while((ch=='Y')||ch=='y');

            
         

        }
    }
}
