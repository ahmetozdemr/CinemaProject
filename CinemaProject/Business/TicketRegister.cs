using CinemaProject.DataAccess;
using CinemaProject.Entities;
using CinemaProject.Core.Utilities;
using System;
using System.Linq;
using CinemaProject.Business;

namespace CinemaProject.Business
{
    public class TicketRegister : IOperation
    {
        public void Add(byte selectedSeatNumber, byte selectedFilmNumber, Films films, Seats seats, Ticket ticket, Tickets tickets, ref int ticketId, int activeUserId, UserData userData)
        {
            ticket.Id = userData.UserDataGet()[activeUserId - 1].Id;
            ticket.FirstName = userData.UserDataGet()[activeUserId - 1].FirstName;
            ticket.LastName = userData.UserDataGet()[activeUserId - 1].LastName;
            ticket.FilmName = films.filmList[selectedFilmNumber - 1].Name;
            ticket.FilmPrice = films.filmList[selectedFilmNumber - 1].Price;
            ticket.DateTime = DateTime.Now;

            tickets.TicketList.Add(new Ticket() { Id = ticket.Id, FirstName = ticket.FirstName, LastName = ticket.LastName, FilmName = ticket.FilmName, FilmPrice = ticket.FilmPrice, DateTime = ticket.DateTime, SeatNo = seats.SeatList[selectedSeatNumber - 1].Id });
            Console.Clear();

        }
    }
}
