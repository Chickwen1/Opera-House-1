using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Event NewEvent()
        {
            string newEvent = txtEvent.Text;
            string newPerformer = txtPerformer.Text;
            string newConcessions = txtConcessions.Text;
            DateTime newDateTime = DateTime.Parse(dtpNewDate.Text);
            double ticketPrice = double.Parse(txtTicketPrice.Text);
            int newTickets = int.Parse(txtTicketsAvailable.Text);
            
            Event createEvent = new Event(newEvent, newPerformer, newConcessions, newDateTime, newTickets, ticketPrice);
            
            if (cboEvent.Text != newEvent)
            {
                cboEvent.Items.Add(newEvent);
                return createEvent;
            }
            else
            {
                return createEvent;
            }
        }

        public void btnBuyTickets_Click_1(object sender, EventArgs e)
        {
            
            int ticketsPurchased = int.Parse(txtBuyTickets.Text);
            //int newAvailableTickets = int.Parse(txtTicketsAvailable.Text);
            lstEvent.Items.Clear();

            lstEvent.Items.Add("You Have Bought " + ticketsPurchased + " tickets for " + NewEvent().EventTitle);
            lstEvent.Items.Add("Your Total Price For Tickets: " + NewEvent().SellTicket(ticketsPurchased).ToString("C"));
            lstEvent.Items.Add("Total Available After Purchase: " + NewEvent().UpdateTicketsBought(ticketsPurchased));

        }

        public void btnReturnTickets_Click(object sender, EventArgs e)
        {
            int ticketReturn = int.Parse(txtReturnTickets.Text);
            lstEvent.Items.Clear();
            lstEvent.Items.Add("You Returned " + NewEvent().UpdateTicketsReturned(ticketReturn) +" tickets for " + NewEvent().EventTitle);
            lstEvent.Items.Add("Amount Refunded: " + NewEvent().ReturnTicket(ticketReturn).ToString("C"));
            lstEvent.Items.Add("Total Available Tickets Now: " + NewEvent().UpdateTicketsReturned(ticketReturn));
        }

        public void btnNewEvent_Click(object sender, EventArgs e)
        {
            NewEvent();
        }

        public void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {     
            cboEvent.SelectedItem.ToString();
            lstEvent.Items.Add("Date: " + NewEvent().EventDate);
            lstEvent.Items.Add("Event Title: " + NewEvent().EventTitle);
            lstEvent.Items.Add("Performer: " + NewEvent().Performer);
            lstEvent.Items.Add("Concessions Available for Event?: " + NewEvent().Concessions);
            lstEvent.Items.Add("Available Tickets: " + NewEvent().AvailableTickets);
            lstEvent.Items.Add("Price Per Ticket: " + NewEvent().TicketPrice.ToString("C"));
        }
    }
}
