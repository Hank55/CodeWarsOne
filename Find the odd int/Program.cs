using System;

namespace Find_the_odd_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(greet("Niks"));
            Console.WriteLine(greet(""));
            Console.WriteLine(greet(null));
        }

        public static string greet(string name)
        {
            if (name == null)
            {
                return null;
            }
            else if (name == string.Empty)
            {
                return null;
            }
            else
            {
                return "hello " + name + "!";
            }
        }
    }
}
