using CinemaProject.Data;
using CinemaProject.Entity;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Operation
{
    public class TicketInfo
    {
        public byte Show(Tickets tickets)
        {
            foreach (var item in tickets.TicketList)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t==========CİNEMA BİLETİ==========");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bilet No :{0}", item.Id);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tAd :{0}", item.FirstName);
                Console.WriteLine("\tSoyad :{0}", item.LastName);
                Console.WriteLine("\tFilm Adı :{0}", item.FilmName);
                Console.WriteLine("\tKoltuk Numarası:{0}", item.SeatNo);
                Console.WriteLine("\tBilet Fİyatı:{0} TL", item.FilmPrice);
                Console.WriteLine("\tAlınma Tarihi:{0}", item.DateTime);
                Console.WriteLine("\t=================================");
                Console.WriteLine("");
                Console.ResetColor();
            }

            byte response = 0;
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("Yeni bilet almak için");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" 1");
                    Console.ResetColor();
                    Console.WriteLine(" sayısını tuşlayınız");

                    Console.Write("İşlemi sonlandırmak için");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" 2");
                    Console.ResetColor();
                    Console.WriteLine(" sayısını tuşlayınız");
                    response = byte.Parse(Console.ReadLine());

                    a = (response == 1) || (response == 2) ? false : true;
                }
                catch
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    a = true;
                }
            }
            Console.Clear();
            return response;
        }
    }
}
