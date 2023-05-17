using CinemaProject.Business.Abstract;
using CinemaProject.Business.Concrete;
using CinemaProject.DataAccess.Concrete.InMemory;

namespace CinemaProject.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }
        private static void Start()
        {
            IUserService userService = new UserManager(new InMemoryUserDal());

            Console.WriteLine("1 Kayıt Ol");
            Console.WriteLine("2 Giriş Yap");
            int num = Int16.Parse(Console.ReadLine());
            int activeUserId = default;
            if (num == 1)
            {
                userService.Add();
                activeUserId = userService.Login();
            }
            else
            {
                activeUserId = userService.Login();
            }

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
