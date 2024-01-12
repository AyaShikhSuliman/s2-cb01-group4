using Logic.DalInterfaces;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Ticket
{
    public class TicketManager : ITicketManager
    {
        private ITicketDataManager ticketDataManager;
        public TicketManager(ITicketDataManager ticketDataManager)
        {
            this.ticketDataManager = ticketDataManager;
        }


        public void AddTicket(Ticket ticket)
        {
            ticketDataManager.AddTicket(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return ticketDataManager.ReadTickets();
        }
    }
}
