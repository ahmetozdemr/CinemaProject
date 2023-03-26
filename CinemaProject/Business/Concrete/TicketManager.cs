using CinemaProject.Business.Abstract;
using CinemaProject.Core.Utilities.Trivia;
using CinemaProject.DataAccess;
using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        IUserService _userService;
        IFilmService _filmService;
        ISeatService _seatService;
        int _activeUserId;
        int _selectedSeatNumber;

        public TicketManager(ITicketDal ticketDal, IUserService userService, IFilmService filmService, ISeatService seatService,int activeUserId,int selectedSeatNumber)
        {
            _ticketDal = ticketDal;
            _userService = userService;
            _filmService = filmService;
            _seatService = seatService;
            _activeUserId= activeUserId;
            _selectedSeatNumber = selectedSeatNumber;   
        }
        public void Add()
        {
            _ticketDal.Add(new Ticket()
            {
                Id = _userService.GetAll()[_activeUserId - 1].Id,
                FirstName = _userService.GetAll()[_activeUserId - 1].FirstName,
                LastName = _userService.GetAll()[_activeUserId - 1].LastName,
                FilmName = _filmService.GetAll[selectedFilmNumber - 1].Name,
                FilmPrice = _filmService.GetAll[selectedFilmNumber - 1].Price,
                DateTime = DateTime.Now,
                SeatNo = _seatService.GetAll[selectedSeatNumber - 1].Id
            });
            Console.Clear();
        }

        public List<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
