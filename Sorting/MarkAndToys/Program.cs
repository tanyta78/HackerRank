using System;

namespace MarkAndToys
{
    class Program
    {
        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            var maxToysCanBuy = 0;
            var toysNumber = prices.Length;
            Array.Sort(prices);
            for (int i = 0; i < toysNumber; i++)
            {
                var currentPrice = prices[i];
                if (currentPrice <= k)
                {
                    maxToysCanBuy++;
                    k -= currentPrice;
                }else{ break;}
            }

            return maxToysCanBuy;
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
                ;
            int result = maximumToys(prices, k);

            Console.WriteLine(result);

        }
    }
}
