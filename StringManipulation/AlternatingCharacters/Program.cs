namespace AlternatingCharacters
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }
        }

        private static int alternatingCharacters(string s)
        {
            int deletion = 0;
            var currentEl = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (currentEl==s[i])
                {
                    deletion++;
                    continue;
                }

                currentEl = s[i];
            }

            return deletion;
        }
    }
}
