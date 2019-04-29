namespace FrequencyQueries
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        // Complete the freqQuery function below.
        static List<int> freqQuery(List<List<int>> queries)
        {
            var dict = new Dictionary<int, int>();
            var frequencies = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (var query in queries)
            {
                var action = query[0];
                var value = query[1];

                if (action == 1)
                {
                    if (!dict.ContainsKey(value))
                    {
                        dict.Add(value, 0);
                    }

                    var initValue = dict[value];
                    dict[value] = initValue + 1;

                    if (!frequencies.ContainsKey(initValue))
                    {
                        frequencies.Add(initValue, 0);
                    }

                    if (!frequencies.ContainsKey(initValue + 1))
                    {
                        frequencies.Add(initValue + 1, 0);
                    }

                    frequencies[initValue] -= 1;
                    frequencies[initValue + 1] += 1;

                }

                if (action == 2 && dict.ContainsKey(value))
                {
                    var currValue = dict[value];
                    if (currValue > 0)
                    {
                        dict[value] = currValue - 1;

                        frequencies[currValue - 1] += 1;
                        frequencies[currValue] -= 1;
                    }
                }

                if (action == 3)
                {
                    if (!frequencies.ContainsKey(value))
                    {
                        result.Add(0);
                    }
                    else
                    {
                        result.Add(frequencies[value] > 0 ? 1 : 0);
                    }

                }
            }

            return result;
        }

        static void Main(string[] args)
        {


            int q = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> ans = freqQuery(queries);

            Console.WriteLine(String.Join("\n", ans));
            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "result.txt");
            File.WriteAllText(destPath, String.Join("\n", ans));

        }
    }
}
