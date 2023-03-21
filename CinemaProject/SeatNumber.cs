using CinemaProject.Data;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public class SeatNumber
    {
        public byte Show(byte chooseFilmNumber, Seats seats, Tickets tickets)
        {

            // Seats seats = new Seats();

            int t = 0;
            for (int i = 0; i < 3; i++)
            {
                Stars.Show(58);
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (seats.seatList[t].checkFill == true)
                    {
                        Console.Write("*Koltuk {0}\t", seats.seatList[t].Id);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*Satıldı {0}\t", seats.seatList[t].Id);
                    }

                    t++;
                }
                Console.WriteLine();
            }

            Stars.Show(58);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bir koltuk seçiniz :");
            byte chooseSeatNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            return chooseSeatNumber;

            //Tickets tickets = new Tickets();
            // tickets.Show(chooseSeatNumber, chooseFilmNumber);
        }
    }
}
