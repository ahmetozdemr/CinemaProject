using Business.Concrete;
using Business.InstanceFactory;
using CinemaProject.Business.Abstract;
using CinemaProject.Business.Concrete;
using CinemaProject.DataAccess.Concrete.InMemory;

namespace CinemaProject.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstPage();
            Console.ReadKey();
        }
        private static void FirstPage()
        {
            IUserService userService;
            int activeUserId;
            UserLoginPage.Start(out userService,out activeUserId);

            IFilmService filmService = new FilmManager(new InMemoryFilmDal(), new InMemoryCategoryDal());
            ISeatService seatService = new SeatManager(new InMemorySeatDal());
            ITicketService ticketService = new TicketManager(new InMemoryTicketDal());

            while (true)
            {
                int selectedCategoryNumber = filmService.GetAllInVision();
                int selectedFilmNumber = filmService.GetAllByCategoryId(selectedCategoryNumber);
                int selectedSeatNumber = seatService.GetAllByFilmId(selectedFilmNumber);
                ticketService.Add(userService, filmService, seatService, activeUserId, selectedSeatNumber, selectedFilmNumber);

                int request = ticketService.GetAll();
                if (request == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

}
