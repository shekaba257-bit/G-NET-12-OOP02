using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session02_OOP
{
    internal class Ticket
    {
        private string movieName;
        private double price;

        // Static counter
        private static int ticketCounter = 0;

        public int TicketId { get; private set; }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }

        public string MovieName
        {
            get => movieName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    movieName = value;
            }
        }

        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public double PriceAfterTax => Price * 1.14;

        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            TicketId = ++ticketCounter;
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public static int GetTotalTicketsSold() => ticketCounter;

        public override string ToString()
        {
            return $"TicketId: {TicketId}, Movie: {MovieName}, Type: {Type}, Seat: {Seat}, Price: {Price}, PriceAfterTax: {PriceAfterTax:F2}";
        }
    }
}
