using System;
using System.Linq;

namespace Convert_number_to_reversed_array_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 348597;

            var longNumber = Digitize(number);

            foreach (var item in longNumber)
            {
                Console.WriteLine(item);
            }
        }

        public static long[] Digitize(long n)
        {
            var stringArray = n.ToString();

            var charArray = stringArray.ToCharArray();


            long[] result = charArray.Select(i => long.Parse(i.ToString()))
                .Reverse()
                .ToArray();

            return result;
        }
    }
}
  