using System;
using CinemaProject.Entity;

namespace CinemaProject.Other
{
    public class Ticket : Customer
    {
     
        public string FilmName { get; set; }
        public double FilmPrice { get; set; }
        public DateTime DateTime { get; set; }
    }
}
