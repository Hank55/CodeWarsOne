using System;
using System.Collections;
using System.Linq;

namespace Find_Count_of_Most_Frequent_Item_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            var list1 = new int[] { 3, -1, 1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3,9,9,9,9,9,9,9 };
            Console.WriteLine(MostFrequentItemCount(list));
            Console.WriteLine(MostFrequentItemCount(list1));
        }

        public static int MostFrequentItemCount(int[] collection)
        {

           if (collection.Length == 0)
            {
                return 0;
            }
            else 
                return collection.GroupBy(x => x).Max(g => g.Count());
        }
    }
}
