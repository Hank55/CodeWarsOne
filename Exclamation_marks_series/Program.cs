using System;
using System.Collections.Generic;
using System.Linq;

namespace Exclamation_marks_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product("!??"));
            Console.WriteLine(Product("!!??"));
        }

        public static int Product(string str)
        {

            return str.Count(c => c == '!') * str.Count(c => c == '?');

            //var charArray = str.ToCharArray();

            //List<char> questionMark = new List<char>();
            //List<char> exclamationMark = new List<char>();

            //foreach (var item in charArray)
            //{
            //    if (item == '?')
            //    {
            //        questionMark.Add(item);
            //    }
            //    else if (item == '!')
            //    {
            //        exclamationMark.Add(item);
            //    }
            //}

            //int sum = questionMark.Count * exclamationMark.Count;

            //return sum;
        }
    }
}
