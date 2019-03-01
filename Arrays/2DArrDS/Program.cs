namespace _2DArrDS
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }

        private static int hourglassSum(int[][] arr)
        {
            var maxSum = int.MinValue;
            for (int row = 1; row < arr.GetLength(0)-1; row++)
            {
                for (int col = 1; col < arr.GetLength(0)-1; col++)
                {
                    var centerCell = arr[row][col];
                    var upperRowSum = arr[row-1][col-1] + arr[row-1][col] + arr[row-1][col+1];
                    var downRowSum = arr[row+1][col-1] + arr[row+1][col] + arr[row+1][col+1];
                    var currentSum = upperRowSum + centerCell + downRowSum;
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }
    }
}
