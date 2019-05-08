namespace ChallengeOne
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format(Constants.WelcomeMessage, Constants.LowestThickness, Constants.HighestThickness));

            var letterThickness = Helpers.GetLetterThickness();

            var draw = new Draw();
            draw.DrawMentorMateLogo(letterThickness);
        }

    }
}
