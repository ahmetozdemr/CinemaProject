using System;
using System.Collections.Generic;
using CinemaProject.Other;

namespace CinemaProject.Data
{
    public class Seats : Seat
    {
        private List<Seat> _seatList;
        private int _listLenght;
        public Seats(List<Seat> seatList, int listLenght)
        {
            _listLenght = listLenght;
            _seatList = seatList;
        }

        public List<Seat> SeatList { get => _seatList; set => _seatList = value; }
        public int ListLenght { get => _listLenght; set => _listLenght = value; }

        public List<Seat> seatList1()
        {

            for (short i = 1; i < ListLenght; i++)
            {
                SeatList.Add(new Seat() { Id = i, checkFill = true });
            }

            return SeatList;
        }
    }
}