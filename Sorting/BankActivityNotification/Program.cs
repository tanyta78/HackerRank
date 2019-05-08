namespace BankActivityNotification
{
    using System;

    class Program
    {
        // Complete the activityNotifications function below.
        static int activityNotifications(int[] expenditure, int d)
        {
            var notification = 0;
            var length = expenditure.Length;

            var freqData = new int[201];
            for (int i = 0; i < d; i++)
            {
                freqData[expenditure[i]]++;
            }

            for (int i = d; i < length; i++)
            {
                double median = GetMedian(freqData, d);

                if (expenditure[i] >= median * 2)
                {
                    notification++;
                }

                freqData[expenditure[i]]++;
                freqData[expenditure[i - d]]--;
            }

            return notification;
        }

        private static double GetMedian(int[] data, int d)
        {
            double median = 0;
            var length = data.Length;
            int count = 0;
            int med1 = -1;
            int med2 = -1;


            for (int i = 0; i < length; i++)
            {
                count += data[i];

                if (d % 2 == 1)
                {
                    if (count > d / 2)
                    {
                        median = i;
                        break;
                    }
                }
                else
                {
                    if (med1 < 0 && count >= d / 2)
                    {
                        med1 = i;
                    }
                    if (med2 < 0 && count >= d / 2 + 1)
                    {
                        med2 = i;
                        median = (med1 + med2) / 2.0;
                        break;
                    }
                }
            }

            return median;
        }


        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp))
                ;
            int result = activityNotifications(expenditure, d);

            Console.WriteLine(result);
        }
    }
}
