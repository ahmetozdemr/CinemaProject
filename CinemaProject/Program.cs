using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using CinemaProject.Data;
using CinemaProject.Other;

namespace CinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   ShowSimplePercentage();

            TheVisionFilms();



            //   ShowSimplePercentage();


            Console.ReadKey();
        }



        static void ShowSimplePercentage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.ResetColor();
            Console.Clear();

        }
        static void StarShow(int starLength)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < starLength; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.ResetColor();
        }

        static void TheVisionFilms()
        {
            StarShow(48);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                 VİZYONDAKİ FİLMLER");
            //  Console.ResetColor();

            StarShow(48);

            Films films = new Films();
            Categories categories = new Categories();
            int t = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Console.ResetColor();
            StarShow(48);
            for (int i = 0; i < categories.categoryList.Count; i++)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;

                for (int j = 0; j < 3; j++)
                {
                    int lngth2;
                    string ls;
                    if (t < 9)
                    {
                        lngth2 = (20 - films.filmList[t].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }
                    else
                    {
                        lngth2 = (19 - films.filmList[t].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }

                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[t].Name, films.filmList[t].Price + " TL", ls, "         ", categories.categoryList[i].Name, t + 1);
                    t++;
                }

                StarShow(48);

            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bir Kategori Seçiniz");
            for (int ii = 0; ii < categories.categoryList.Count; ii++)
            {
                Console.WriteLine("\t{0} => {1} ", ii, categories.categoryList[ii].Name);
            }
            byte chooseCategoryNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            showTheFilmlistCategory(chooseCategoryNumber);


            //ShowTheSeatNumber(chooseCategoryNumber);
        }

        static void showTheFilmlistCategory(byte chooseCategoryNumber)
        {
            Films films = new Films();
            Categories categories = new Categories();

            StarShow(48);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            StarShow(48);
            Console.ResetColor();

            int i = 0;
            while (i < films.filmList.Count)
            {
                if (films.filmList[i].CategoryId == categories.categoryList[chooseCategoryNumber].Id)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int lngth2;
                    string ls;
                    if (i < 9)
                    {
                        lngth2 = (20 - films.filmList[i].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }
                    else
                    {
                        lngth2 = (19 - films.filmList[i].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }

                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[i].Name, films.filmList[i].Price + " TL", ls, "         ", categories.categoryList[chooseCategoryNumber].Name, i + 1);
                }
                i++;
            }
            StarShow(48);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("İzlemek istediğiniz Filmin No suna giriniz:");

            byte chooseFilmNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            ShowTheSeatNumber(chooseFilmNumber);
        }

        static void ShowTheSeatNumber(byte chooseFilmNumber)
        {

            Seats seats = new Seats();
            int t = 0;
            for (int i = 0; i < 3; i++)
            {
                StarShow(58);
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*Koltuk {0}\t", seats.seatList[t].Id);
                    t++;
                }

                Console.WriteLine();
            }
            StarShow(58);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bir koltuk seçiniz :");

            byte chooseSeatNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            ShowTheTicket(chooseSeatNumber, chooseFilmNumber);

        }

        static void ShowTheTicket(byte chooseSeatNumber, byte chooseFilmNumber)
        {
            Films films = new Films();
            Seats seats = new Seats();
            Ticket ticket = new Ticket();   
            Console.ResetColor();
            StarShow(45);
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
            

            List<Ticket> ticketList = new List<Ticket>();
            ticketList.Add(ticket);

            Console.Clear();
            StarShow(30);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\t====CİNEMA BİLETİ====");
            Console.WriteLine("\tAd :{0}", ticket.Name);
            Console.WriteLine("\tSoyad :{0}", ticket.SurName);
            Console.WriteLine("\tFilm Adı :{0}", ticket.FilmName);
            Console.WriteLine("\tKoltuk Numarası:{0}", seats.seatList[chooseSeatNumber - 1].Id);
            Console.WriteLine("\tBilet Fİyatı:{0}", ticket.FilmPrice);
            Console.WriteLine("\tAlınma Tarihi:{0}", ticket.DateTime);
        Console.ResetColor();
            StarShow(30);

            Console.WriteLine("Yeni bilet almak için 1 sayısını tuşlayınız");
            Console.WriteLine("Ya da herhangi bir rakam basınız");
            byte click = byte.Parse(Console.ReadLine());
            Console.Clear();
            if (click == 1)
            {
                TheVisionFilms();
            }

        }

    }

}
