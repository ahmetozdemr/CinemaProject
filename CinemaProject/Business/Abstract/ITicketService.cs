using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Abstract
{
    public interface ITicketService
    {
        void Add(IUserService userService, IFilmService filmService, ISeatService seatService, int activeUserId, int selectedSeatNumber);
        int GetAll();
    }
}
