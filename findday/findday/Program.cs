using System;

namespace findday
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            top:
            Console.WriteLine("1.sunday\t2.MOnday\t3.Tuesday\t4.wednesday\t5.Thursday\t6.Friday\t7.Saturday");
            n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("enter the vaild number");
                    goto top;

            }
        }
    }
}
