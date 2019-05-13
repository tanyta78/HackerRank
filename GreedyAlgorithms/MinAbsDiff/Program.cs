namespace MinAbsDiff
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int result = minimumAbsoluteDifference(arr);

            Console.WriteLine(result);
        }

        private static int minimumAbsoluteDifference(int[] arr)
        {
            var len = arr.Length;
            var minAbsDifference = int.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < len - 1; i++)
            {
                var currentDiff = Math.Abs(arr[i] - arr[i + 1]);
                if (currentDiff < minAbsDifference)
                {
                    minAbsDifference = currentDiff;

                }
            }


            return minAbsDifference;
        }
    }
}
