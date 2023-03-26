using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataAccess.Concrete.InMemory
{
    public class InMemorySeatDal : ISeatDal
    {
        List<Seat> _seats;
        public InMemorySeatDal()
        {
            _seats = new List<Seat>();
            for (short i = 1; i < 13; i++)
            {
                _seats.Add(new Seat() { Id = i, CheckFill = true });
            }
        }

        public void Add(Seat seat)
        {
            _seats.Add(seat);
        }

        public List<Seat> GetAll()
        {
            return _seats;
        }
    }
}
