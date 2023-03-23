using CinemaProject.Data;
using CinemaProject.Other;
using CinemaProject.Trivia;
using System;
using System.Linq;

namespace CinemaProject.Operation
{
    public class Tickets
    {
        public byte Show(byte selectedSeatNumber, byte selectedFilmNumber, Films films, Seats seats, Ticket ticket)
        {
            string name = null;
            string surName = null;
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
                    name = Console.ReadLine();
                    Console.WriteLine("Lütfen Soyadınız Giriniz :");
                    surName = Console.ReadLine();

                    //Bu kısımda name ve surName değişkenlerinin boş,null ya da sadece boşluktan oluşup oluşmadığını kontrol ediyor.
                    //Tüm kuralları sağlıyorsa while döngüsünden çıkıyor
                    //Burdaki y değişkeni if ten sonra bir hata oluşursa hata çıktısı verirsin diye konuldu
                    if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(surName))
                    {
                        foreach (var item1 in name)
                        {
                            if (item1 != ' ')
                            {
                                foreach (var item2 in surName)
                                {
                                    if (item2 != ' ')
                                    {
                                        x = false;
                                        y = true;
                                    }
                                }
                                y= false;
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


            ticket.Name = name;
            ticket.SurName = surName;
            ticket.FilmName = films.filmList[selectedFilmNumber - 1].Name;
            ticket.FilmPrice = films.filmList[selectedFilmNumber - 1].Price;
            ticket.DateTime = DateTime.Now;


            Console.Clear();
            Stars.Show(30);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\t====CİNEMA BİLETİ====");
            Console.WriteLine("\tAd :{0}", ticket.Name);
            Console.WriteLine("\tSoyad :{0}", ticket.SurName);
            Console.WriteLine("\tFilm Adı :{0}", ticket.FilmName);
            Console.WriteLine("\tKoltuk Numarası:{0}", seats.SeatList[selectedSeatNumber - 1].Id);
            Console.WriteLine("\tBilet Fİyatı:{0}", ticket.FilmPrice);
            Console.WriteLine("\tAlınma Tarihi:{0}", ticket.DateTime);
            Console.ResetColor();
            Stars.Show(30);

            Console.WriteLine("Yeni bilet almak için 1 sayısını tuşlayınız");
            Console.WriteLine("Ya da herhangi bir rakam basınız");
            byte response = byte.Parse(Console.ReadLine());
            Console.Clear();
            return response;
        }
    }
}
