using System.Collections.Generic;
using CinemaProject.Other;

namespace CinemaProject.Data
{
    public class Seats : Seat
    {
        public List<Seat> seatList = new List<Seat>()
      {
          new Seat(){Id = 1,checkFill = true},new Seat(){Id = 2,checkFill = true},
          new Seat(){Id = 3,checkFill = true},new Seat(){Id = 4,checkFill = true},
          new Seat(){Id = 5,checkFill = true},new Seat(){Id = 6,checkFill = true},
          new Seat(){Id = 7,checkFill = true},new Seat(){Id = 8,checkFill = true},
          new Seat(){Id = 9,checkFill = true},new Seat(){Id = 10,checkFill = true},
          new Seat(){Id = 11,checkFill = true},new Seat(){Id = 12,checkFill = true}
      };
    }
}
