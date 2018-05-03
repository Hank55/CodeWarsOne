using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_The_Stray_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 2, 1, 1 };
            var array2 = new int[] { 17, 17, 3, 17, 17, 17, 17 };
            var array3 = new int[] { 17, 17, 17, 17, 17, 17, 8 };


            Console.WriteLine(Stray(array1));
            Console.WriteLine(Stray(array2));
            Console.WriteLine(Stray(array3));
        }

        public static int Stray(int[] numbers)
        {
            int oddNumber = numbers[0];

            foreach (var number in numbers)
            {
                if (number != oddNumber || (number != numbers[1] && number != numbers[2]))
                {
                    oddNumber = number;
                    break;
                }
            }
            return oddNumber;
        }
    }
}
