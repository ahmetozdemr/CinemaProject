﻿using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataAccess
{
    public class SeatsCollective: IData
    {
        public void Show(List<Seats> seatsCollective)
        {
            List<Seat> seatList;
            int listLenght;
            Seats seats = null;        

            short i = 1;
            while (i < 13)
            {
                seatList = new List<Seat>();
                listLenght = 13;
                seats = new Seats(seatList, listLenght);

                seatsCollective.Add(new Seats(seatList, listLenght));

                i++;
            }
        }
    }
}