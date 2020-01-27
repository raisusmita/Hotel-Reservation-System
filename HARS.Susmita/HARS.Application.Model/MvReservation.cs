using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Model
{
    public class MvReservation
    {
        public int ReservationId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int CustomerId { get; set; }
        public int BookingId { get; set; }
        public int RoomId { get; set; }


    }
}
