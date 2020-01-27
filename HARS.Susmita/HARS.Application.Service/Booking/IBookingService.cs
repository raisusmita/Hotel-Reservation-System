using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Booking
{
    public interface IBookingService
    {
        /// <summary>
        /// Add New Booking
        /// </summary>
        /// <param name="mvBooking">object of Booking</param>
        /// <returns>id of Booking</returns>
        string AddBooking(MvBooking mvBooking);

        /// <summary>
        /// Get Booking Information
        /// </summary>
        /// <param name="bookingId">id of Booking</param>
        /// <returns>List of Bookings</returns>
        List<MvBooking> GetBooking(int bookingId, string searchText);

        /// <summary>
        /// Edit existing Booking
        /// </summary>
        /// <param name="mvBooking">object of  Booking</param>
        void EditBooking(MvBooking mvBooking);

        /// <summary>
        /// Delete Booking
        /// </summary>
        /// <param name="bookingId">id of Booking</param>
        void DeleteBooking(int bookingId);
    }
}
