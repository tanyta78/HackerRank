namespace GreedyFlorist
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

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
                ;
            int minimumCost = getMinimumCost(k, c);

            Console.WriteLine(minimumCost);
        }

        private static int getMinimumCost(int peopleCount, int[] costs)
        {
            costs = costs.OrderByDescending(c => c).ToArray();
            var flowersToBuy = costs.Length;
            var result = 0;

            if (flowersToBuy<=peopleCount)
            {
                return costs.Take(peopleCount).Sum();
            }

            result += costs.Take(peopleCount).Sum();
            var curtPurchase = 1;
          
            for (int i = peopleCount; i < flowersToBuy; i++)
            {
                if (i%peopleCount==0)
                {
                    curtPurchase++;
                }

                result += costs[i] * curtPurchase;
            }


            return result;
        }
    }
}
