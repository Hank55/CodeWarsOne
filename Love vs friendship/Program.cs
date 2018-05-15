using System;
using System.Linq;

namespace Love_vs_friendship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordsToMarks("HelloWorld"));
        }

        public static int WordsToMarks(string str)
        {
            int sum = 0;
            foreach (char item in str.ToLower())
            {
                sum = sum + item - 96;
            }
            return sum;
        }
    }
}
