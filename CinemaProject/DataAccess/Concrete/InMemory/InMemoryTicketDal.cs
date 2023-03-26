using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataAccess.Concrete.InMemory
{
    public class InMemoryTicketDal : ITicketDal
    {
        List<Ticket> _tickets;
        public InMemoryTicketDal()
        {
            _tickets = new List<Ticket>();
        }

        public void Add(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public List<Ticket> GetAll()
        {
            return _tickets;
        }

    }
}
