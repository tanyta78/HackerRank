namespace JumpingOnClouds
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var clouds = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            var jumps = GetJums(clouds);
            Console.WriteLine(jumps);
        }

        private static int GetJums(int[] clouds)
        {
            var result = 0;
            var currentPos = 0;
            var len = clouds.Length;

            while (currentPos + 2 < len)
            {
                if (clouds[currentPos + 2] == 0)
                {
                    currentPos += 2;
                }
                else
                {
                    currentPos++;
                }

                result++;

            }

            if (len == 2 || currentPos+2==len)
            {
                result++;
            }

            return result;
        }
    }
}
