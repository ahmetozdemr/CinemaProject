﻿using System;
using System.Collections.Generic;
using CinemaProject.Business;
using CinemaProject.DataAccess;
using CinemaProject.Entities;

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
            List<User> users = new List<User>();
            UserData userData = new UserData(users);
            UserLoginOperation userLogin = new UserLoginOperation();
            int activeUserId = userLogin.Login(userData.UserDataGet());
            UserLoginOperation userLoginOperation = new UserLoginOperation();

            var seatsCollectiveList = new List<Seats>();
            var seatsCollective = new SeatsCollective();
            seatsCollective.Show(seatsCollectiveList);


            var ticketList = new List<Ticket>();
            //Data klasöründeki instancelar
            var films = new Films();
            var categories = new Categories();
            var tickets = new Tickets(ticketList);

            //Entity clasöründeki instancelar
            var ticket = new Ticket();


            //Operation klasöründeki instancelar
            var filmInVision = new FilmInVision();
            var filmlistByCategory = new FilmlistByCategory();
            var chooseSeatNumber = new ChooseSeatNumber();
            var ticketRegister = new TicketRegister();
            var ticketInfo = new TicketInfo();

            //Bu kısımda operasyonları sırasıyla çalışıyor ve işlem sona erdilmediği sürece kendini tekrar ediyor
            while (true)
            {

                byte selectedCategoryNumber = filmInVision.Show(films, categories);
                byte selectedFilmNumber = filmlistByCategory.Show(selectedCategoryNumber, films, categories);

                byte selectedSeatNumber = chooseSeatNumber.Show(seatsCollectiveList[selectedFilmNumber - 1].SeatListGive());



                int ticketId = 0;
                ticketRegister.Add(selectedSeatNumber, selectedFilmNumber, films, seatsCollectiveList[selectedFilmNumber - 1], ticket, tickets, ref ticketId, activeUserId, userData);

                byte response = ticketInfo.Show(tickets);
                if (response == 1)
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