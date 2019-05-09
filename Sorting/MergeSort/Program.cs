namespace MergeSort
{
    using System;
    using System.Linq;

    public class Program
    {
        public static long Split(int[] arr)
        {
            long totalCount = 0;
            var n = arr.Length;
            if (n < 2)
            {
                return totalCount;
            }

            var mid = n / 2;
            var left = arr.Take(mid).ToArray();
            var right = arr.Skip(mid).ToArray();

            long leftCount = Split(left);
            long rightCount = Split(right);
            totalCount += leftCount + rightCount + Merge(left, right, arr);
            return totalCount;
        }

        public static long Merge(int[] left, int[] right, int[] arr)
        {
            long countInversion = 0;

            var nL = left.Length;
            var nR = right.Length;

            var leftArrayIndex = 0;
            var rightArrayIndex = 0;
            var arrIndex = 0;

            while (leftArrayIndex < nL && rightArrayIndex < nR)
            {
                if (left[leftArrayIndex] <= right[rightArrayIndex])
                {
                    arr[arrIndex] = left[leftArrayIndex];
                    leftArrayIndex++;
                }
                else
                {
                    arr[arrIndex] = right[rightArrayIndex];
                    rightArrayIndex++;
                    countInversion += nL - leftArrayIndex;
                }

                arrIndex++;
            }

            while (leftArrayIndex < nL)
            {
                arr[arrIndex] = left[leftArrayIndex];
                arrIndex++;
                leftArrayIndex++;
            }

            while (rightArrayIndex < nR)
            {
                arr[arrIndex] = right[rightArrayIndex];
                arrIndex++;
                rightArrayIndex++;
            }

            return countInversion;
        }

        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++) {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                    ;
                long result = countInversions(arr);

                Console.WriteLine(result);
            }

        }

        public static long countInversions(int[] arr)
        {
            return Split(arr);
        }
    }
}
