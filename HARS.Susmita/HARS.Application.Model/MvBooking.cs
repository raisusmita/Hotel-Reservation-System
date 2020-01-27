using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Model
{
    public class MvBooking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int NoOfGuest { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int NoOfRoom { get; set; }
        public bool Status { get; set; }
        public int ServiceId { get; set; }
        public string Service { get; set; }
        public int CustomerId { get; set; }



    }
}
