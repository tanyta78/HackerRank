namespace ValidString
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);
        }

        private static string isValid(string s)
        {
            if (s.Length<=3)
            {
                return "YES";
            }

            int[] letterCount = new int[26];

            foreach (char c in s)
            {
                letterCount[c - 'a']++;
            }

            var max = letterCount.Where(e=>e!=0).Max();
            var min = letterCount.Where(e => e != 0).Min();
            
            if ((max-min==1 && letterCount.Count(e => e==max)==1)
                ||(max==min))
            {
                return "YES";
            }

            if (min==1 && letterCount.Count(e => e==min)==1)
            {
             var changed = letterCount.Where(e => e != 0 && e != min).ToArray();
              return changed[0]==max ? "YES" : "NO";

            }

            return "NO";
        }
    }
}
