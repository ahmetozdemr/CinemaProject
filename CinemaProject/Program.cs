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
            NewMethod();
            // NewMethod1();

            Console.ReadKey();
        }

        private static void NewMethod1()
        {
            Seats seats = new Seats();
            Update(seats.seatList);

            ClassUpdate classUpdate = new ClassUpdate();
            classUpdate.Updat2(seats.seatList);

            ClassShow classShow = new ClassShow();
            classShow.Showseat(seats.seatList);

            //foreach (var VARIABLE in seats.seatList)
            //{
            //    Console.WriteLine("Id : {0} Boş: {1}",VARIABLE.Id, VARIABLE.checkFill);
            //}
        }

        static void Update(List<Seat> seatList)
        {
            seatList[0].checkFill = false;
        }
        private static void NewMethod()
        {

            // SimplePercentage.Show();

            Seats seats = new Seats();
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
                byte selectedSeatNumber = seatNumber.Show(seats.seatList);

                byte response = tickets.Show(selectedSeatNumber, selectedFilmNumber, films, seats, ticket);
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
