using System;
using CinemaProject.Entities.Abstract;

namespace CinemaProject.Entities.Concrete
{
    public class Ticket : User, IEntity
    {
        public string FilmName { get; set; }
        public double FilmPrice { get; set; }
        public int SeatNo { get; set; }
        public DateTime DateTime { get; set; }
    }
}
