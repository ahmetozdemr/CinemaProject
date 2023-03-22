using System;
using System.Collections.Generic;
using CinemaProject.Data;
using CinemaProject.Operation;
using CinemaProject.Other;

namespace CinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();

            //List<Seat> seatList1;
            //int listLenght;
            //Seats seats = null;

            //List<Seats> seatsCollective = new List<Seats>();

            //short i = 1;
            //while (i < 13)
            //{
            //    seatList1 = new List<Seat>();
            //    listLenght = 13;
            //    seats = new Seats(seatList1, listLenght);

            //    seatsCollective.Add(new Seats(seatList1, listLenght));
            //    Console.WriteLine(seatsCollective.Count);

            //    i++;
            //}

            //foreach (var VARIABLE in seatsCollective)
            //{
            //    Console.WriteLine("----------:  " + VARIABLE.seatList1().Count);

            //}

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
                // Console.WriteLine(seatsCollective.Count);

                i++;
            }

            Ticket ticket = new Ticket();
            Films films = new Films();
            Tickets tickets = new Tickets();
            SeatNumber seatNumber = new SeatNumber();
            Categories categories = new Categories();
            FilmsInVision filmsInVision = new FilmsInVision();
            FilmlistCategory filmlistCategory = new FilmlistCategory();

            while (true)
            {
                byte selectedCategoryNumber = filmsInVision.Show(films, categories);
                byte selectedFilmNumber = filmlistCategory.Show(selectedCategoryNumber, films, categories);

                byte selectedSeatNumber = seatNumber.Show(seatsCollective[selectedFilmNumber].seatList1());
                ;
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
