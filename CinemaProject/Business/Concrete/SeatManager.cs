using CinemaProject.Business.Abstract;
using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Concrete
{
    public class SeatManager : ISeatService
    {
        ISeatDal _seatDal;
        public SeatManager(ISeatDal seatDal)
        {
            _seatDal = seatDal;
        }

        public void Add()
        {
            
        }

        public List<Seat> GetAll()
        {
            return _seatDal.GetAll();
        }
    }
}
