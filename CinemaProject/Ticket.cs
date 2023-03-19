using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Other;

namespace CinemaProject
{
    public class Ticket
    {
        public int Id { get; set; } 
        public Film FilmName { get; set; }  
        public  Film FilmPrice { get; set; }    
        public DateTime DateTime { get; set;}
    }
}
