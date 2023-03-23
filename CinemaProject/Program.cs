using System;
using System.Collections.Generic;
using CinemaProject.Data;
using CinemaProject.Entity;
using CinemaProject.Operation;

namespace CinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        private static void Start()
        {
            // SimplePercentage.Show();

            List<Seat> seatList;
            int listLenght;
            Seats seats = null;

            List<Seats> seatsCollective = new List<Seats>();

            short i = 1;
            while (i < 13)
            {
                seatList = new List<Seat>();
                listLenght = 13;
                seats = new Seats(seatList, listLenght);

                seatsCollective.Add(new Seats(seatList, listLenght));

                i++;
            }
            List<Ticket> ticketList = new List<Ticket>();
            Tickets tickets = new Tickets(ticketList);
            int ticketId = 0;

            Ticket ticket = new Ticket();
            Films films = new Films();
            TicketsInfo ticketsInfo = new TicketsInfo();
            ChooseSeatNumber chooseSeatNumber = new ChooseSeatNumber();
            Categories categories = new Categories();
            FilmsInVision filmsInVision = new FilmsInVision();
            FilmlistByCategory filmlistByCategory = new FilmlistByCategory();

            while (true)
            {
                byte selectedCategoryNumber = filmsInVision.Show(films, categories);
                byte selectedFilmNumber = filmlistByCategory.Show(selectedCategoryNumber, films, categories);

                byte selectedSeatNumber = chooseSeatNumber.Show(seatsCollective[selectedFilmNumber].SeatListGive());

                byte response = ticketsInfo.Show(selectedSeatNumber, selectedFilmNumber, films, seatsCollective[selectedFilmNumber], ticket, tickets, ticketId);
                if (response == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            // SimplePercentage.Show();
        }
    }

}
