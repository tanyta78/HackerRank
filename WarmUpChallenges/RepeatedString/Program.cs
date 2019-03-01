namespace RepeatedString
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var n = long.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedA(str, n));

        }

        private static long RepeatedA(string str, long n)
        {
            long result = 0;
            var len = str.Length;
            var rest = n % len;

            if (n >= len)
            {
                var count = str.Count(x => x == 'a');
                var full = n / len;
                result += full * count;
            }

            for (int i = 0; i < rest; i++)
            {
                if (str[i] == 'a')
                {
                    result++;
                }
            }

            return result;


        }
    }
}
