using CinemaProject.Business.Abstract;
using CinemaProject.Core.Utilities.Trivia;
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

        public List<List<Seat>> GetAll()
        {
            return _seatDal.GetAllInRoom();
        }

        public int GetAllByFilmId()
        {
            int r = 0;
            for (int i = 0; i < 3; i++)
            {
                Stars.Show(58);
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (_seatDal.GetAll()[r].CheckFill == true)
                    {
                        Console.Write("*Koltuk {0}\t", _seatDal.GetAll()[r].Id);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*Satıldı {0}\t", _seatDal.GetAll()[r].Id);
                    }
                    r++;
                }
                Console.WriteLine();
            }
            Stars.Show(58);
            Console.ResetColor();

            byte selectedSeatNumber = 0;
            bool checkSelectedNumber = true;
            while (checkSelectedNumber)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bir koltuk seçiniz :");
                    selectedSeatNumber = byte.Parse(Console.ReadLine());
                    if (selectedSeatNumber < 13 && selectedSeatNumber > 0)
                    {
                        _seatDal.GetAll()[selectedSeatNumber - 1].CheckFill = false;
                        checkSelectedNumber = !checkSelectedNumber;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                        Console.ResetColor();
                        checkSelectedNumber = true;
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    checkSelectedNumber = true;
                }
            }

            Console.ResetColor();
            Console.Clear();
            return selectedSeatNumber;
        }
    }
}
