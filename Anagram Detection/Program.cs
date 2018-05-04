using System;
using System.Linq;

namespace Anagram_Detection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("foefet", "toffee"));
            Console.WriteLine(IsAnagram("apple", "pale"));
            Console.WriteLine(IsAnagram("Buckethead", "DeathCubeK"));
        }

        public static bool IsAnagram(string test, string original)
        {
            string aa = string.Concat(test.ToLower().OrderBy(c => c)).ToLower();
            string bb = string.Concat(original.ToLower().OrderBy(d => d.ToString())).ToLower();

            if (aa == bb)
                return true;
            else
                return false;
        }
    }
}
