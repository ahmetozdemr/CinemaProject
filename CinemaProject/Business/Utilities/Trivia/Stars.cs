using System;

namespace CinemaProject.Business.Utilities.Trivia
{
    public static class Stars
    {
        public static void Show(int starLength)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < starLength; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
