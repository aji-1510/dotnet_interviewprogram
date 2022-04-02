using System;

namespace percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            int subj1, subj2, subj3, subj4, subj5, total;
            float per;
            char ch;
            lable:
            Console.WriteLine("enter the subj1 mark");
            subj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the subj2 mark");
            subj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the subj3 mark");
            subj3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the subj4 mark");
            subj4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the subj5 mark");
            subj5 = int.Parse(Console.ReadLine());
            total = (subj1 + subj2 + subj3 + subj4 + subj5);
            per = total / 5;
            Console.WriteLine("your total mark" + total);
            Console.WriteLine("\n\nyour total percentage " +per+"%");
            Console.WriteLine("do you want run again Y/N");
            ch = Convert.ToChar(Console.ReadLine());
            if ((ch == 'Y') || (ch == 'y'))
             {
                goto lable;
            }

        }
    }
}
