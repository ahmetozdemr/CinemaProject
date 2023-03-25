using System;

namespace CinemaProject.Entities
{
    public class Ticket : Customer, IEntity
    {
        public string FilmName { get; set; }
        public double FilmPrice { get; set; }
        public int SeatNo { get; set; }
        public DateTime DateTime { get; set; }
    }
}
