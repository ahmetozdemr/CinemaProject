using CinemaProject.Data;
using CinemaProject.Other;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public class Tickets
    {
        public byte Show(byte chooseSeatNumber, byte chooseFilmNumber, Films films, Seats seats, Ticket ticket)
        {
            Console.ResetColor();
            Stars.Show(45);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lütfen Adınızı Giriniz :");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınız Giriniz :");
            string surName = Console.ReadLine();

            ticket.Name = name;
            ticket.SurName = surName;
            ticket.FilmName = films.filmList[chooseFilmNumber - 1].Name;
            ticket.FilmPrice = films.filmList[chooseFilmNumber - 1].Price;
            ticket.DateTime = DateTime.Now;


            Console.Clear();
            Stars.Show(30);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\t====CİNEMA BİLETİ====");
            Console.WriteLine("\tAd :{0}", ticket.Name);
            Console.WriteLine("\tSoyad :{0}", ticket.SurName);
            Console.WriteLine("\tFilm Adı :{0}", ticket.FilmName);
            Console.WriteLine("\tKoltuk Numarası:{0}", seats.seatList[chooseSeatNumber - 1].Id);
            Console.WriteLine("\tBilet Fİyatı:{0}", ticket.FilmPrice);
            Console.WriteLine("\tAlınma Tarihi:{0}", ticket.DateTime);
            Console.ResetColor();
            Stars.Show(30);

            Console.WriteLine("Yeni bilet almak için 1 sayısını tuşlayınız");
            Console.WriteLine("Ya da herhangi bir rakam basınız");
            byte click = byte.Parse(Console.ReadLine());
            Console.Clear();
            return click;
        }
    }
}
