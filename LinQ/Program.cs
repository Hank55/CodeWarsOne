using System;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bo", "ann", "Liii" };

            var sortedNames = names.Where(n => n.Length > 2);

            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
