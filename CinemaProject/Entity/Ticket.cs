using System;

namespace CinemaProject.Entity
{
    public class Ticket : Customer, IEntity
    {

        public string FilmName { get; set; }
        public double FilmPrice { get; set; }
        public int SeatNo { get; set; }
        public DateTime DateTime { get; set; }
    }
}
