namespace CommonChild
{
    using System;

    class Program
    {
        // Complete the commonChild function below.
        static int commonChild(string s1, string s2) {
            var s1Length = s1.Length;
            var s2Length = s2.Length;
            var memo = new int [s1Length+1,s2Length+1];
            
            for (int i = 0; i < s1Length; i++)
            {
                for (int j = 0; j < s2Length; j++)
                {
                    if (s1[i]==s2[j])
                    {
                        memo[i + 1, j + 1] = memo[i, j] + 1;
                    }
                    else
                    {
                        memo[i + 1, j + 1] = Math.Max(memo[i + 1, j], memo[i, j + 1]);
                    }
                }
            }

            return memo[s1Length, s2Length];
        }

        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = commonChild(s1, s2);

            Console.WriteLine(result);
        }
    }
}
