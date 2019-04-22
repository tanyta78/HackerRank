namespace CountTriplets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // Complete the countTriplets function below.
        static long countTriplets(List<long> arr, long r)
        {
            long triplets = 0;
            Dictionary<long, long> occurrence = new Dictionary<long, long>();
            Dictionary<long, long> dictPairs = new Dictionary<long, long>();

            for (int index = arr.Count - 1; index >= 0; index--)
            {
                var element = arr[index];
                if (dictPairs.ContainsKey(element * r))
                    triplets += dictPairs[element* r];

                if (occurrence.ContainsKey(element * r))
                {
                    if (dictPairs.ContainsKey(element))
                        dictPairs[element] = dictPairs[element] + occurrence[element * r];
                    else
                        dictPairs[element] = occurrence[element * r];
                }

                if (!occurrence.ContainsKey(element))
                    occurrence.Add(element, 1);
                else
                    occurrence[element]++;
            }

            return triplets;

        }

        static void Main(string[] args)
        {
            string[] nr = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nr[0]);

            long r = Convert.ToInt64(nr[1]);

            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
                                    .Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            long ans = countTriplets(arr, r);

            Console.WriteLine(ans);


        }
    }
}
