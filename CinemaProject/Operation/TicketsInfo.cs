using CinemaProject.Data;
using CinemaProject.Entity;
using CinemaProject.Trivia;
using System;
using System.Linq;

namespace CinemaProject.Operation
{
    public class TicketsInfo
    {
        public byte Show(byte selectedSeatNumber, byte selectedFilmNumber, Films filmList, Seats seatList, Ticket ticket,Tickets ticketList)
        {
            string firstName = null;
            string lastName = null;
            bool x = true;
            bool y = true;
            while (x)
            {
                try
                {
                    Console.ResetColor();
                    Stars.Show(45);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Lütfen Adınızı Giriniz :");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Lütfen Soyadınız Giriniz :");
                    lastName = Console.ReadLine();

                    //Bu kısımda name ve surName değişkenlerinin boş,null ya da sadece boşluktan oluşup oluşmadığını kontrol ediyor.
                    //Tüm kuralları sağlıyorsa while döngüsünden çıkıyor
                    //Burdaki y değişkeni if ten sonra bir hata oluşursa hata çıktısı verirsin diye konuldu
                    if (!String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName))
                    {
                        foreach (var item1 in firstName)
                        {
                            if (item1 != ' ')
                            {
                                foreach (var item2 in lastName)
                                {
                                    if (item2 != ' ')
                                    {
                                        x = false;
                                        y = true;
                                    }
                                }
                                y = false;
                            }
                            y = false;
                        }
                        y = false;
                    }
                    else
                    {
                        x = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen gerekli yerleri doldurunuz");
                        Console.ResetColor();
                    }
                    if (!y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen gerekli yerleri doldurunuz");
                        Console.ResetColor();
                    }

                }
                catch
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    x = true;
                }
            }


            ticket.FirstName = firstName;
            ticket.LastName = lastName;
            ticket.FilmName = filmList.filmList[selectedFilmNumber - 1].Name;
            ticket.FilmPrice = filmList.filmList[selectedFilmNumber - 1].Price;
            ticket.DateTime = DateTime.Now;


            Console.Clear();
            Stars.Show(30);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\t====CİNEMA BİLETİ====");
            Console.WriteLine("\tAd :{0}", ticket.FirstName);
            Console.WriteLine("\tSoyad :{0}", ticket.LastName);
            Console.WriteLine("\tFilm Adı :{0}", ticket.FilmName);
            Console.WriteLine("\tKoltuk Numarası:{0}", seatList.SeatList[selectedSeatNumber - 1].Id);
            Console.WriteLine("\tBilet Fİyatı:{0}", ticket.FilmPrice);
            Console.WriteLine("\tAlınma Tarihi:{0}", ticket.DateTime);
            Console.ResetColor();
            Stars.Show(30);

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
