using System;
using System.Collections.Generic;
using System.Linq;

namespace Vampire_Numbers
{
    class Program
    {
        //Our loose definition of Vampire Numbers can be described as follows
        static void Main(string[] args)
        {
            Console.WriteLine(vampire_test(21, 6));
            Console.WriteLine(vampire_test(22, 6));
        }

        public static bool vampire_test(long x, long y)
        {
            return (x * y).ToString().OrderBy(c => c).SequenceEqual((x.ToString()+ y).OrderBy(c => c));
        }
    }
}
