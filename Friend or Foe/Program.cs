using System;
using System.Collections.Generic;
using System.Linq;

namespace Friend_or_Foe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };

            var result = FriendOrFoe(names);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
                
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(n => n.Length == 4);
        }
    }
}
