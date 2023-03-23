using CinemaProject.Entity;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;


namespace CinemaProject.Operation
{
    public class ChooseSeatNumber
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
                    if (seatList[r].CheckFill == true)
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

            byte selectedSeatNumber = 0;
            bool x = true;
            while (x)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bir koltuk seçiniz :");
                    selectedSeatNumber = byte.Parse(Console.ReadLine());
                    if (selectedSeatNumber < 13 && selectedSeatNumber > 0)
                    {
                        seatList[selectedSeatNumber - 1].CheckFill = false;
                        x = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                        Console.ResetColor();
                        x = true;
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    x = true;
                }
            }

            Console.ResetColor();
            Console.Clear();
            return selectedSeatNumber;

        }
    }
}
