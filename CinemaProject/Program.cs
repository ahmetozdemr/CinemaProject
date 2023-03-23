using System;
using System.Collections.Generic;
using CinemaProject.Data;
using CinemaProject.Entity;
using CinemaProject.Operation;
using CinemaProject.Trivia;

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
            SimplePercentage.Show();

            var seatsCollectiveList = new List<Seats>();
            var seatsCollective = new SeatsCollective();
            seatsCollective.Show(seatsCollectiveList);


            var ticketList = new List<Ticket>();
            //Data klasöründeki instancelar
            var films = new Films();
            var categories = new Categories();
            var tickets = new Tickets(ticketList);

            //Entity clasöründeki instancelar
            var ticket = new Ticket();


            //Operation klasöründeki instancelar
            var filmInVision = new FilmInVision();
            var filmlistByCategory = new FilmlistByCategory();
            var chooseSeatNumber = new ChooseSeatNumber();
            var ticketRegister = new TicketRegister();
            var ticketInfo = new TicketInfo();


            while (true)
            {
                byte selectedCategoryNumber = filmInVision.Show(films, categories);
                byte selectedFilmNumber = filmlistByCategory.Show(selectedCategoryNumber, films, categories);

                byte selectedSeatNumber = chooseSeatNumber.Show(seatsCollectiveList[selectedFilmNumber - 1].SeatListGive());

                int ticketId = 0;
                ticketRegister.Add(selectedSeatNumber, selectedFilmNumber, films, seatsCollectiveList[selectedFilmNumber - 1], ticket, tickets, ref ticketId);

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
            SimplePercentage.Show();
        }
    }

}
