using System;
using System.Linq;

namespace Sort_array_by_string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfWords = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };

            foreach (var item in SortByLength(listOfWords))
            {
                Console.WriteLine(item);
            }
        }

        public static string[] SortByLength(string[] array)
        {
            var sortedValues = array.OrderBy(x => x.Length).ToArray();
            return sortedValues;
        }
    }
}
