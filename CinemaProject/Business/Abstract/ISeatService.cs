using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Abstract
{
    public interface ISeatService
    {
        void Add();
        // List<Seat> GetAll();
        List<List<Seat>> GetAll();
        int GetAllByFilmId(int filmId);
    }
}
