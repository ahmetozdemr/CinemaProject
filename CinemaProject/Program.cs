using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using CinemaProject.Data;
using CinemaProject.Other;
using CinemaProject.Trivia;

namespace CinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            // SimplePercentage.Show();

            Seats seats = new Seats();
            Ticket ticket = new Ticket();
            Films films = new Films();
            Tickets tickets = new Tickets();
            Categories categories = new Categories();

            FilmsInVision filmsInVision = new FilmsInVision();
            byte selectedCategoryNumber = filmsInVision.Show(films, categories);

            FilmlistCategory filmlistCategory = new FilmlistCategory();
            byte selectedFilmNumber = filmlistCategory.Show(selectedCategoryNumber, films, categories);

            SeatNumber seatNumber = new SeatNumber();
            byte selectedSeatNumber = seatNumber.Show(selectedFilmNumber, seats, tickets);


            byte click = tickets.Show(selectedSeatNumber, selectedFilmNumber, films, seats, ticket);

            if (click == 1)
            {
                goto start;
            }

            // SimplePercentage.Show();

            Console.ReadKey();
        }
    }

}
