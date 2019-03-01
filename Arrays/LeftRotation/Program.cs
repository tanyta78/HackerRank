namespace LeftRotation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(input[0]);

            int rotations = Convert.ToInt32(input[1]);

            int[] numberArr = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
            int[] result = rotLeft(numberArr, rotations);
            Console.WriteLine(string.Join(" ",result));
        }

        private static int[] rotLeft(int[] numArr, int rotations)
        {
            var len = numArr.Length;
            var rest = rotations % len;
            var result = new int[len];

            for (int i = 0; i < len; i++)
            {
                var index = (i + rest) % len;
                result[i] = numArr[index];
            }

            return result;
        }
    }
}
