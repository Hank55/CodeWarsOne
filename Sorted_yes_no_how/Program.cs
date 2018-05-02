using System;
using System.Linq;

namespace Sorted_yes_no_how
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSortedAndHow(new[] { 1, 2 ,3}));
            Console.WriteLine(IsSortedAndHow(new[] { 15, 7, 3, -8 }));
            Console.WriteLine(IsSortedAndHow(new[] { 4, 2, 30 }));

        }


        public static string IsSortedAndHow(int[] array)
        {
            var orderedByAsc = array.OrderBy(d => d);
            var orderedByDesc = array.OrderByDescending(d => d);

            if (array.SequenceEqual(orderedByAsc))
            {
                return "yes, ascending";
            }
            else if (array.SequenceEqual(orderedByDesc))
            {
                return "yes, descending";
            }
            else
            {
                return "No";
            }
        }
    }
}
