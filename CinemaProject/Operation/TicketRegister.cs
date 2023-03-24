using CinemaProject.Data;
using CinemaProject.Entity;
using CinemaProject.Trivia;
using System;
using System.Linq;

namespace CinemaProject.Operation
{
    public class TicketRegister : IOperation
    {
        public void Add(byte selectedSeatNumber, byte selectedFilmNumber, Films films, Seats seats, Ticket ticket, Tickets tickets, ref int ticketId)
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

            ticketId++;
            ticket.Id = ticketId;
            ticket.FirstName = firstName;
            ticket.LastName = lastName;
            ticket.FilmName = films.filmList[selectedFilmNumber - 1].Name;
            ticket.FilmPrice = films.filmList[selectedFilmNumber - 1].Price;
            ticket.DateTime = DateTime.Now;

            tickets.TicketList.Add(new Ticket() { Id = ticket.Id, FirstName = ticket.FirstName, LastName = ticket.LastName, FilmName = ticket.FilmName, FilmPrice = ticket.FilmPrice, DateTime = ticket.DateTime, SeatNo = seats.SeatList[selectedSeatNumber - 1].Id });
            Console.Clear();

        }
    }
}
