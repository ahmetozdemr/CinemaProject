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
            Tickets ticketList = new Tickets();

            Ticket ticket = new Ticket();
            Films filmList = new Films();
            TicketsInfo ticketsInfo = new TicketsInfo();
            ChooseSeatNumber chooseSeatNumber = new ChooseSeatNumber();
            Categories categoryList = new Categories();
            FilmsInVision filmsInVision = new FilmsInVision();
            FilmlistByCategory filmlistCategory = new FilmlistByCategory();

            while (true)
            {
                byte selectedCategoryNumber = filmsInVision.Show(filmList, categoryList);
                byte selectedFilmNumber = filmlistCategory.Show(selectedCategoryNumber, filmList, categoryList);

                byte selectedSeatNumber = chooseSeatNumber.Show(seatsCollective[selectedFilmNumber].seatList());

                byte response = ticketsInfo.Show(selectedSeatNumber, selectedFilmNumber, filmList, seatsCollective[selectedFilmNumber], ticket, ticketList);
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
