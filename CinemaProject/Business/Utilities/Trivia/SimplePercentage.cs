using System;
using System.Threading;

namespace CinemaProject.Business.Utilities.Trivia
{
    public static class SimplePercentage
    {
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.ResetColor();
            Console.Clear();

        }
    }
}
