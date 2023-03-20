using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaProject.Trivia
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
