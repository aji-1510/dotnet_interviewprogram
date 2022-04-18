using System;

namespace names_store_in_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a C# program that requests three names of people
              from the user and stores them in an array of objects of
              type Person. To do this, first create a Person class
              that has a Name property of type string and override
              the ToString() method. */

            int total = 3;
            Person[] persons = new Person[total];

            Console.WriteLine("Enter three names");
            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    name = Console.ReadLine()
                };
            }

            Console.Write("\n");
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadLine();
        }
    }
    public class Person
    {
        public string name
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "Hai.. I'm " + name;
        }
    }
    
}
