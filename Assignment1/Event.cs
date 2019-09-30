using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class Event
    {
        public string EventTitle { get; set; }
        public string Performer { get; set; }
        public string Concessions { get; set; }
        public DateTime EventDate { get; set; }
        public int AvailableTickets { get;  set; }
        public int SoldTickets { get; set; }
        public double TicketPrice { get; set; }

        public Event(string EventTitle, string Performer, string Concessions, DateTime EventDate, int AvailableTickets, double TicketPrice)
        {
            this.EventTitle = EventTitle;
            this.Performer = Performer;
            this.EventDate = EventDate;
            this.AvailableTickets = AvailableTickets;
            this.Concessions = Concessions;
            this.TicketPrice = TicketPrice;
        }

        public int UpdateTicketsBought(int numberTickets)
        {
            return AvailableTickets - numberTickets;
        }

        public int UpdateTicketsReturned(int numberTickets)
        {
            return AvailableTickets + numberTickets;
        }

        public double SellTicket(int numberTickets)
        {
            SoldTickets += numberTickets;
            return this.TicketPrice * numberTickets;
        }

        public double ReturnTicket(int numberTickets)
        {
            if (numberTickets + AvailableTickets > AvailableTickets)
            {
                MessageBox.Show("Returned tickets can not exceed available tickets!");
            }

            return TicketPrice * numberTickets;
        }

    }
}
