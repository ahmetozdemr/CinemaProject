using CinemaProject.Other;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;


namespace CinemaProject.Operation
{
    public class SeatNumber
    {
        public byte Show(List<Seat> seatList)
        {
            int r = 0;
            for (int i = 0; i < 3; i++)
            {
                Stars.Show(58);
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (seatList[r].checkFill == true)
                    {
                        Console.Write("*Koltuk {0}\t", seatList[r].Id);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*Satıldı {0}\t", seatList[r].Id);
                    }
                    r++;
                }
                Console.WriteLine();
            }
            Stars.Show(58);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Bir koltuk seçiniz :");
            byte selectedSeatNumber = byte.Parse(Console.ReadLine());
            seatList[selectedSeatNumber - 1].checkFill = false;


            Console.ResetColor();
            Console.Clear();
            return selectedSeatNumber;

        }
    }
}
