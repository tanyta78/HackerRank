using System;

namespace HashTableRansomNote
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }

        private static void checkMagazine(string[] magazine, string[] note)
        {
            if (magazine.Length < note.Length)
            {
                Console.WriteLine("No");
                return;
            }

            var wordDict = new Dictionary<string, int>();
            foreach (var word in magazine)
            {
                if (!wordDict.ContainsKey(word))
                {
                    wordDict.Add(word,0);
                }

                wordDict[word] += 1;
            }

            foreach (var wordNeeded in note)
            {
                if (!wordDict.ContainsKey(wordNeeded))
                {
                    Console.WriteLine("No");
                    return;
                }

               var count= wordDict[wordNeeded]--;

               if (count<0)
               {
                   Console.WriteLine("No");
                   return;
               }
            }

            Console.WriteLine("Yes");
        }
    }
}
