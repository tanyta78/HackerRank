namespace CountingValleys
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            var path = Console.ReadLine();

            int result = CountingValleys(steps, path);
            Console.WriteLine(result);
        }

        private static int CountingValleys(int steps, string path)
        {
            var directions = path.ToCharArray();
            var result = 0;
            var level = 0;

            foreach (var step in directions)
            {
                var prevLevel = level;
                switch (step)
                {
                    case 'D':
                        level -= 1;
                        break;
                    case 'U':
                        level += 1;
                        break;
                }

                if (level == 0 && prevLevel < 0)
                {
                    result += 1;
                }
            }

            return result;
        }
    }
}
