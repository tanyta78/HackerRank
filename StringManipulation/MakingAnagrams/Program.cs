namespace MakingAnagrams
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = makeAnagram(a, b);

            Console.WriteLine(res);
        }

        private static int makeAnagram(string a, string b)
        {
            var result = 0;
            var aL = a.ToCharArray();
            var bL = b.ToCharArray();
            var letterCounts = new int[26];

            foreach (char c in aL)
            {
                letterCounts[c - 'a']++;
            }

            foreach (char c in bL)
            {
                letterCounts[c - 'a']--;
            }

            foreach (int count in letterCounts)
            {
                result += Math.Abs(count);
            }
            
            return result;
        }
    }
}
