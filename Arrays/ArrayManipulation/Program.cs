namespace ArrayManipulation
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
          string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++) {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);
            Console.WriteLine(result);
        }

        private static long arrayManipulation(int arrLength, int[][] queries)
        {
            var arrMaxValue = Int64.MinValue;
            var arr = new long[arrLength];
            var queryCount = queries.Length;

            for (int i = 0; i < queryCount; i++)
            {
                var startIdx = queries[i][0]-1;
                var endIdx = queries[i][1];
                var val = queries[i][2];
                arr[startIdx] += val;
                if (endIdx<arrLength)
                {
                    arr[endIdx] -= val;
                }
            }

            long currentSum = 0;
            foreach (var el in arr)
            {
                currentSum += el;
                if (currentSum>=arrMaxValue)
                {
                    arrMaxValue = currentSum;
                }
            }
            return arrMaxValue;
        }
    }
}
