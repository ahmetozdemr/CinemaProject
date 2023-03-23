using CinemaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Data
{
    public class Tickets
    {
        private List<Ticket> _ticketList;

        //public Tickets(List<Ticket> ticketList)
        //{
        //    _ticketList = ticketList;
        //}

        public List<Ticket> TicketList
        {
            get { return _ticketList; }
            set { _ticketList = value; }
        }


        public List<Ticket> TicketListGive()
        {

            return TicketList;
        }
    }
}
