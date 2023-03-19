using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Other;

namespace CinemaProject.Data
{
    public class Seats : Seat
    {
        public List<Seat> seatList = new List<Seat>()
      {
          new Seat(){Id = 1},new Seat(){Id = 2},new Seat(){Id = 3},new Seat(){Id = 4},new Seat(){Id = 5},
          new Seat(){Id = 6},new Seat(){Id = 7},new Seat(){Id = 8},new Seat(){Id = 9},new Seat(){Id = 10},
          new Seat(){Id = 11},new Seat(){Id = 12}
      };
    }
}
