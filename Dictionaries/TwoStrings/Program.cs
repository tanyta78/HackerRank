using System;

namespace TwoStrings
{
    using System.Linq;
    using System.Runtime.Remoting.Messaging;

    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }

        }

        private static string twoStrings(string s1, string s2)
        {
            return s1.Intersect(s2).Any() ? "YES" : "NO";
        }
    }
}
