namespace FrequencyQueries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // Complete the freqQuery function below.
        static List<int> freqQuery(List<List<int>> queries)
        {
            var dict = new Dictionary<int, int>();
            var output = new List<int>();
            foreach (var query in queries)
            {
                var type = query[0];
                var element = query[1];
                switch (type)
                {
                    case 1: 
                       if (!dict.ContainsKey(element))
                       {
                           dict.Add(element,0);
                       }

                       dict[element]+=1;
                        break;
                    case 2: 
                        if (dict.ContainsKey(element))
                        {
                            dict[element]-=1;
                        }
                        break;
                    case 3: 
                        if (dict.ContainsValue(element))
                        {
                            output.Add(1);
                        }
                        else
                        {
                            output.Add(0);
                        }
                        break;
                }
            }

            return output;
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


        }
    }
}
