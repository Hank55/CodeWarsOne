using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5] { 1, 1, 5, 1,1 };

            var numbers1 = new int[5] { 2, 2, 2, 7,2 };
            var numbers2 = new int[5] { 2, 2, 2, -7,2 };


            Console.WriteLine(GetUnique(numbers));
            Console.WriteLine(GetUnique(numbers1));
            Console.WriteLine(GetUnique(numbers2));
        }

        public static int GetUnique(int[] numbers)
        {
            int oddNumber = numbers[0];

            foreach (var number in numbers)
            {
                if (number != oddNumber)
                {
                    oddNumber = number;
                    break;
                }
            }
            return oddNumber;
        }


    }
}
