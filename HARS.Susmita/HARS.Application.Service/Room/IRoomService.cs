using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Room
{
    public interface IRoomService
    {
        /// <summary>
        /// Add New Room
        /// </summary>
        /// <param name="mvRoom">object of Room</param>
        /// <returns>id of Room</returns>
        int AddRoom(MvRoom mvRoom);

        /// <summary>
        /// Get Room Information
        /// </summary>
        /// <param name="roomId">id of Room</param>
        /// <returns>List of Rooms</returns>
        List<MvRoom> GetRoom(int roomId);

        /// <summary>
        /// Edit existing Room
        /// </summary>
        /// <param name="mvRoom">object of  Room</param>
        void EditRoom(MvRoom mvRoom);

        /// <summary>
        /// Delete Room
        /// </summary>
        /// <param name="roomId">id of Room</param>
        void DeleteRoom(int roomId);
    }
}
