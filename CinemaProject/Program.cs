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

            TicketInfo ticketInfo = new TicketInfo();   

            Ticket ticket = new Ticket();
            Films films = new Films();
            TicketRegister ticketRegister = new TicketRegister();
            ChooseSeatNumber chooseSeatNumber = new ChooseSeatNumber();
            Categories categories = new Categories();
            FilmInVision filmInVision = new FilmInVision();
            FilmlistByCategory filmlistByCategory = new FilmlistByCategory();

            while (true)
            {
                byte selectedCategoryNumber = filmInVision.Show(films, categories);
                byte selectedFilmNumber = filmlistByCategory.Show(selectedCategoryNumber, films, categories);

                byte selectedSeatNumber = chooseSeatNumber.Show(seatsCollective[selectedFilmNumber-1].SeatListGive());

                ticketRegister.Add(selectedSeatNumber, selectedFilmNumber, films, seatsCollective[selectedFilmNumber-1], ticket, tickets,ref ticketId);

                byte response = ticketInfo.Show(tickets);
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
