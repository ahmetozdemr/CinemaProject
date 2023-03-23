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

            List<Seat> seatList1;
            int listLenght;
            Seats seats = null;

            List<Seats> seatsCollective = new List<Seats>();

            short i = 1;
            while (i < 13)
            {
                seatList1 = new List<Seat>();
                listLenght = 13;
                seats = new Seats(seatList1, listLenght);

                seatsCollective.Add(new Seats(seatList1, listLenght));

                i++;
            }

            Ticket ticket = new Ticket();
            Films films = new Films();
            TicketsInfo tickets = new TicketsInfo();
            ChooseSeatNumber chooseSeatNumber = new ChooseSeatNumber();
            Categories categories = new Categories();
            FilmsInVision filmsInVision = new FilmsInVision();
            FilmlistByCategory filmlistCategory = new FilmlistByCategory();

            while (true)
            {
                byte selectedCategoryNumber = filmsInVision.Show(films, categories);
                byte selectedFilmNumber = filmlistCategory.Show(selectedCategoryNumber, films, categories);

                byte selectedSeatNumber = chooseSeatNumber.Show(seatsCollective[selectedFilmNumber].seatList1());
                
                byte response = tickets.Show(selectedSeatNumber, selectedFilmNumber, films, seatsCollective[selectedFilmNumber], ticket);
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
