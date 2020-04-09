using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BookingSeats
    {
        public void Standard(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Write("Please input the amount of seats: ");
            int seats = int.Parse(Console.ReadLine());


            double price = seats * 9.99;// NO. OF seats will be multiplied by the price

            BookingTickets Ticket = new BookingTickets();

            Ticket.FinalTicket(Title, Length, AR, DT, Screen, "Standard", seats.ToString(), price.ToString());
        }

        public void VIP(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Write("Please input the amount of seats: ");
            int seats = int.Parse(Console.ReadLine());

            double price = seats * 15.00;

            BookingTickets Ticket = new BookingTickets();

            Ticket.FinalTicket(Title, Length, AR, DT, Screen, "Standard", seats.ToString(), price.ToString());

            
        }
    }
}
