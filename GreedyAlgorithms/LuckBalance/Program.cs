namespace LuckBalance
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[][] contests = new int[n][];

            for (int i = 0; i < n; i++)
            {
                contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
            }

            int result = luckBalance(k, contests);

            Console.WriteLine(result);
        }

        private static int luckBalance(int k, int[][] contests)
        {
            int result = contests.Where(el => el[1] == 0).Sum(el => el[0]);

            int[] important = contests.Where(el => el[1] == 1).Select(el => el[0]).OrderByDescending(el => el).ToArray();

            result += important.Take(k).Sum() - important.Skip(k).Sum();

            return result;
        }
    }
}
