using System;
using System.Collections.Generic;
using System.Linq;

namespace Descending_Order
{
    class Program
    {
        //Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(21445));
            Console.WriteLine(DescendingOrder(145263));
        }
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}
