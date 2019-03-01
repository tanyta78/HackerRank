namespace NewYearChaos
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                var peopleCount = int.Parse(Console.ReadLine());
                var finalOrder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Calc(finalOrder);
            }
        }

        private static void MinimumBribes(int[] finalOrder)
        {
            var isChaotic = false;

            for (int i = 1; i <= finalOrder.Length; i++)
            {
                var result = finalOrder[i - 1] - i;
                if (result > 2)
                {
                    isChaotic = true;
                    break;
                }

            }

            if (isChaotic)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                DoBribe(finalOrder);

            }

        }

        private static void DoBribe(int[] finalOrder)
        {
            var bribes = 0;

            var len = finalOrder.Length;
            var currentOrder = Enumerable.Range(1, len).ToArray();

            for (int i = 0; i < len; i++)
            {
                if (currentOrder[i] != finalOrder[i])
                {
                    var currentNum = finalOrder[i];
                    var diff = currentNum - i - 1;
                    if (diff > 0)
                        bribes += diff;
                    else
                        bribes += 1;
                    var start = currentOrder.Take(i).ToList();
                    start.Add(currentNum);
                    var end = currentOrder.Skip(i).ToList();
                    end.Remove(currentNum);
                    currentOrder = start.Union(end).ToArray();

                }
            }

            Console.WriteLine(bribes);
        }

        private static void Calc(int[] finalOrder)
        {
           var bribes = 0;
           for (int i = finalOrder.Length - 1; i >= 0; i--)
            {
                var result = finalOrder[i] - i - 1;
                if (result > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (int j = Math.Max(0,finalOrder[i]-2); j < i; j++)
                {
                    if (finalOrder[j]>finalOrder[i])
                    {
                        bribes++;
                    }
                }

            }

           Console.WriteLine(bribes);

            
        }
    }
}
