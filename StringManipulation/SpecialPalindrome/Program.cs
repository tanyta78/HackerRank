namespace SpecialPalindrome
{
    using System;
    using System.Linq;

    class Program
    {
        // Complete the substrCount function below.
        static long substrCountOpt(int n, string s)
        {
            long count = 0;
            var len = s.Length;

            for (int i = 0; i < len; i++)
            {
                int innerCounter = 1;
                int counterDown = 0;
                int counterUp = 1;

                while (i - innerCounter >= 0 && i + innerCounter < len
                                             && s[i - innerCounter] == s[i - 1] 
                                             && s[i + innerCounter] == s[i - 1]) {
                    count++;
                    innerCounter++;
                }

                while (i - counterDown >= 0 && i + counterUp <len 
                                            && s[i - counterDown] == s[i]
                                            && s[i + counterUp] == s[i]) {
                    count++;
                    counterDown++;
                    counterUp++;
                }
            }


            return count + len;
        }

        static long substrCount(int n, string s)
        {
            long palindromeCount = n;

            for (int subLength = 2; subLength <= n; subLength++)
            {
                for (int startIndex = 0; startIndex <= n - subLength; startIndex++)
                {
                    var subString = s.Skip(startIndex).Take(subLength).ToArray();
                    if (isPalindrome(subString, subLength))
                    {
                        palindromeCount++;
                    }
                }
            }

            return palindromeCount;
        }

        private static bool isPalindrome(char[] subString, int subLength)
        {
            var midLen = subString.Length / 2;
            var middleChar = subString[midLen];

            if (subString.All(e => e == middleChar))
            {
                return true;
            }


            if (subLength % 2 == 0) return false;

            var subList = subString.ToList();
            subList.RemoveAt(midLen);
            var lastEl = subList.Last();

            return subList.All(e => e == lastEl);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = substrCount(n, s);

            Console.WriteLine(result);
        }
    }
}
