namespace JimAndOrders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // Complete the jimOrders function below.
        static int[] jimOrders(int[][] orders)
        {
            var serveTimesPerCustomer = new Dictionary<int,int>();

            for (int i = 0; i < orders.Length; i++)
            {
                serveTimesPerCustomer.Add(i + 1, orders[i][0] + orders[i][1]);
            }

            var result = serveTimesPerCustomer.OrderBy(el => el.Value).Select(o=>o.Key).ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] orders = new int[n][];

            for (int i = 0; i < n; i++)
            {
                orders[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            }

            int[] result = jimOrders(orders);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
