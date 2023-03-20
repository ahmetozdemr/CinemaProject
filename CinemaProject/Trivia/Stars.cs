using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Trivia
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
