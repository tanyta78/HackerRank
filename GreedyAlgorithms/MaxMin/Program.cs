namespace MaxMin
{
    using System;

    class Program
    {
        // Complete the maxMin function below.
        static int maxMin(int k, int[] arr)
        {
            Array.Sort(arr);
            var result = int.MaxValue;
            var len = arr.Length;

            for (int i = 0; i < len - k + 1; i++)
            {
                var curtSubArrDiff = arr[i + k - 1] - arr[i];
                if (curtSubArrDiff < result)
                {
                    result = curtSubArrDiff;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }

            int result = maxMin(k, arr);

            Console.WriteLine(result);

        }
    }
}
