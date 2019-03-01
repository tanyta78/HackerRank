using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] socks = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int result = SockMerchants(n, socks);
            Console.WriteLine(result);
        }

        private static int SockMerchants(int n, int[] socks)
        {
            var socksDict = new Dictionary<int,int>();
            foreach (var sock in socks)
            {
                if (!socksDict.ContainsKey(sock))
                {
                    socksDict.Add(sock,0);
                }

                socksDict[sock] += 1;
            }

            var pairsCount = 0;

            foreach (var val in socksDict.Values)
            {
                pairsCount += val / 2;
            }


            return pairsCount;
        }
    }
}
