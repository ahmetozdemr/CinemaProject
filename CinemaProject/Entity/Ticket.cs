using System;

namespace CinemaProject.Entity
{
    public class Ticket : Customer
    {

        public string FilmName { get; set; }
        public double FilmPrice { get; set; }
        public DateTime DateTime { get; set; }
    }
}
