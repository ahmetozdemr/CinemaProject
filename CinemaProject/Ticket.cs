using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Entity;
using CinemaProject.Other;

namespace CinemaProject
{
    public class Ticket:Customer
    {
        public int Id { get; set; } 
        public string FilmName { get; set; }  
        public  double FilmPrice { get; set; }    
        public DateTime DateTime { get; set;}
    }
}
