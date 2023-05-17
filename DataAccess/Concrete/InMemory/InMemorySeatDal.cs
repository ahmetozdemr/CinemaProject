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
        List<List<Seat>> _seatInRoom;
        public InMemorySeatDal()
        {
            _seats = new List<Seat>();
            for (int i = 1; i < 13; i++)
            {
                _seats.Add(new Seat() { Id = i, CheckFill = true });
            }

            _seatInRoom = new List<List<Seat>>()
            {
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
                 _seats,
            };
        }

        //public void Add(Seat seat)
        //{
        //    _seats.Add(seat);
        //}

        //public List<Seat> GetAll()
        //{
        //    return _seats;
        //}
        public List<List<Seat>> GetAllInRoom()
        {
            var result = _seatInRoom[1][1].Id;

            return _seatInRoom;
        }
    }
}
