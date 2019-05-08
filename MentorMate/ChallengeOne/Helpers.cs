namespace ChallengeOne
{
    using System;

    public static class Helpers
    {
        public static int GetLetterThickness()
        {
            int thickness;
            var isNumber = int.TryParse(Console.ReadLine(), out thickness);
            
                while (!isNumber || !CheckConditions(thickness))
                {
                    Console.WriteLine(string.Format(Constants.InvalidInputMessage, Constants.LowestThickness, Constants.HighestThickness));
                    isNumber = int.TryParse(Console.ReadLine(), out thickness);
                }
               
            return thickness;
        }
        
        private static bool CheckConditions(int n)
        {
            return n >= Constants.LowestThickness && n <= Constants.HighestThickness && n % 2 == 1;
        }

        
    }
}
