using System;
using System.Collections.Generic;

namespace SevenAte9
{
    class Program
    {
        //Write a function that removes every lone 9 that is inbetween 7s.
        static void Main(string[] args)
        {
            Console.WriteLine(SevenAteNine("79797"));
        }

        public static string SevenAteNine(string str)
        {
            var numbers = string.Empty;

            var number = str.ToCharArray();


            var list = new List<int>();

            for (int i = 0; i < number.Length; i++)
            {

            }


            return numbers;
        }
    }
}
