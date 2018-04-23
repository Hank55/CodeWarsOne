using System;
using System.Linq;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Accum("abcd"));

        }

        public static String Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}

