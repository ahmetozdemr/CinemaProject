﻿using CinemaProject.Entity;
using System;
using System.Collections.Generic;

namespace CinemaProject.Data
{
    public class Tickets: IData
    {
        private List<Ticket> _ticketList;

        public Tickets(List<Ticket> ticketList)
        {
            _ticketList = ticketList;
        }

        public List<Ticket> TicketList
        {
            get { return _ticketList; }
            set { _ticketList = value; }
        }

    }
}
