using System;

namespace Shortest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("bit-coin take over the world maybe who knows perhaps")); 
        }

        public static int FindShort(string s)
        {
            string[] arrayOfStrings = s.Split(" ");
            foreach (var word in arrayOfStrings)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.Length < s.Length)
                        s = word;
                }
            }
            return s.Length;
        }
    }
}
