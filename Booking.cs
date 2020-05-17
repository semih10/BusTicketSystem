using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class Booking
    {
        public int BookingID;
        public string From;
        public string To;
        public DateTime Date;
        public DateTime Hour;
        public double Price;
        public Booking(int BookingID, string From, string To,
        DateTime Date, DateTime Hour, double Price)
        {
            this.BookingID = BookingID;
            this.From = From;
            this.To = To;
            this.Date = Date;
            this.Hour = Hour;
            this.Price = Price;
        }
    }
}