using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers  = GetIntegersFromList(new List<object>() { 1213213, 2, 6, "Hello World" });

            List<object> number = new List<object>();

            foreach (var item in numbers)
            {
                number.Add(item);
            }

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().Cast<int>();
        }
    }
}
