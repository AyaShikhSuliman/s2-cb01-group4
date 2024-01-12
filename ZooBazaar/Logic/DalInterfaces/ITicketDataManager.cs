using Logic.Classes.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DalInterfaces
{
    public interface ITicketDataManager
    {
        void AddTicket(Ticket ticket);
        List<Ticket> ReadTickets();
    }
}
