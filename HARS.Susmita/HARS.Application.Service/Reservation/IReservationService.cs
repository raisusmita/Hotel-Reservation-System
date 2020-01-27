using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Reservation
{
    public interface IReservationService
    {
        /// <summary>
        /// Add New Reservation
        /// </summary>
        /// <param name="mvBranch">object of Reservation</param>
        /// <returns>id of Reservation</returns>
        int AddReservation(MvReservation mvReservation);

        /// <summary>
        /// Get Reservation Information
        /// </summary>
        /// <param name="reservationId">id of Reservation</param>
        /// <returns>List of Reservations</returns>
        List<MvReservation> GetReservation(int reservationId);

        /// <summary>
        /// Edit existing Reservation
        /// </summary>
        /// <param name="mvReservation">object of  Reservation</param>
        void EditReservation(MvReservation mvReservation);

        /// <summary>
        /// Delete Reservation
        /// </summary>
        /// <param name="reservationId">id of Reservation</param>
        void DeleteReservation(int reservationId);
    }
}
