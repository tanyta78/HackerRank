namespace MinSwaps
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                ;
            int res = MinimumSwaps(arr);
            Console.WriteLine(res);
        }

        private static int MinimumSwaps(int[] arr)
        {
            var count = 0;
            var len = arr.Length;
            var origIndexes = Enumerable.Range(0, len).ToArray();
            Array.Sort(arr, origIndexes);

            for (int i = 0; i < len; i++)
            {
                if (origIndexes[i]==i)
                {
                    continue;
                }

                Swap(origIndexes,i, origIndexes[i]);
                count++;
                i--;
            }

            return count;
        }

        private static void Swap(int[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
