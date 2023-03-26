using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataAccess.Abstract
{
    public interface IFilmDal
    {
        List<Film> GetAll();
        void Add(Film film);
    }
}
