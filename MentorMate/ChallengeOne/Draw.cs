namespace ChallengeOne
{
    using System;

    public class Draw
    {
        public void DrawMentorMateLogo(int letterThickness)
        {
            UpperPart(letterThickness);
            DownPart(letterThickness);
        }

        private static void UpperPart(int n)
        {
            var upperPartRows = (n + 1) / 2;
            for (int i = 0; i < upperPartRows; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(new string(Constants.FreeSymbol, n - i));
                    Console.Write(new string(Constants.LetterSymbol, n + 2 * i));
                    Console.Write(new string(Constants.FreeSymbol, n - 2 * i));
                    Console.Write(new string(Constants.LetterSymbol, n + 2 * i));
                    Console.Write(new string(Constants.FreeSymbol, n - i));
                }

                Console.WriteLine();
            }
        }

        private static void DownPart(int n)
        {
            for (int i = 1; i <= n; i += 2)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(new string(Constants.FreeSymbol, (n - i + 1) / 2));
                    Console.Write(new string(Constants.LetterSymbol, n));
                    Console.Write(new string(Constants.FreeSymbol, i));
                    Console.Write(new string(Constants.LetterSymbol, 2 * n - i));
                    Console.Write(new string(Constants.FreeSymbol, i));
                    Console.Write(new string(Constants.LetterSymbol, n));
                    Console.Write(new string(Constants.FreeSymbol, (n - i + 1) / 2));
                }

                Console.WriteLine();
            }
        }
    }
}
