namespace Sherlock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }
        }

        private static int sherlockAndAnagrams(string s)
        {
            var count = 0;

            for (int endIdx = 1; endIdx < s.Length; endIdx++)
            {
                var memo = new Dictionary<string, int>();
                for (int startIdx = 0; startIdx + endIdx < s.Length; startIdx++)
                {

                    var current = s.Substring(startIdx, endIdx);
                    var sorted = string.Join("", current.ToCharArray().OrderBy(e => e));

                    if (!memo.ContainsKey(sorted))
                    {
                        memo.Add(sorted, 1);
                    }
                    else
                    {
                        count+=memo[sorted];
                        memo[sorted] += 1;
                    }

                }
            }


            return count;
        }

    }
}


