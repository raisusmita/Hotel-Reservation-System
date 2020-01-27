using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Season
{
    public interface ISeasonService
    {
        /// <summary>
        /// Add New Season
        /// </summary>
        /// <param name="mvSeason">object of Season</param>
        /// <returns>id of Season</returns>
        int AddSeason(MvSeason mvSeason);

        /// <summary>
        /// Get Season Information
        /// </summary>
        /// <param name="seasonId">id of Season</param>
        /// <returns>List of Seasons</returns>
        List<MvSeason> GetSeason(int seasonId, string searchText);

        /// <summary>
        /// Edit existing Season
        /// </summary>
        /// <param name="mvSeason">object of  Season</param>
        void EditSeason(MvSeason mvSeason);

        /// <summary>
        /// Delete Season
        /// </summary>
        /// <param name="seasonId">id of Season</param>
        void DeleteSeason(int seasonId);
    }
}
