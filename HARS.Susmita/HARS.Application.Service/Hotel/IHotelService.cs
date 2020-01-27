using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Hotel
{
    public interface IHotelService
    {
        /// <summary>
        /// Add New Hotel
        /// </summary>
        /// <param name="mvHotel">object of hotel</param>
        /// <returns>id of hotel</returns>
        int AddHotel(MvHotel mvHotel);

        /// <summary>
        /// Get Hotel Information
        /// </summary>
        /// <param name="hotelId">id of hotel</param>
        /// <returns>List of hotels</returns>
        List<MvHotel> GetHotel(int hotelId, string searchText);

        /// <summary>
        /// Edit existing hotel
        /// </summary>
        /// <param name="mvHotel">object of  hotel</param>
        void EditHotel(MvHotel mvHotel);

        /// <summary>
        /// Delete Hotel
        /// </summary>
        /// <param name="hotelId">id of hotel</param>
        void DeleteHotel(int hotelId);

    }
}
