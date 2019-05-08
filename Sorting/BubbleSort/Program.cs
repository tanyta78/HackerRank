namespace BubbleSort
{
    using System;

    class Program
    {
        // Complete the countSwaps function below.
        static void CountSwaps(int[] arr)
        {
            var length = arr.Length;
            var swaps = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j);
                        swaps++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {swaps} swaps.");
            Console.WriteLine($"First Element: {arr[0]}");
            Console.WriteLine($"Last Element: {arr[length - 1]}");

        }

        private static void Swap(int[] arr, int j)
        {
            var temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
            CountSwaps(arr);
        }
    }
}
