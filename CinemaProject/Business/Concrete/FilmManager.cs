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
    internal class FilmManager : IFilmService
    {
        IFilmDal _filmDal;
        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }
        public void Add()
        {

        }

        public List<Film> GetAll()
        {
            return _filmDal.GetAll();
        }
    }
}
