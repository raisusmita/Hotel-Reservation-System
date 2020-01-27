using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.ServiceCategory
{
    public interface IServiceCategoryService
    {
        /// <summary>
        /// Add New ServiceCategory
        /// </summary>
        /// <param name="mvServiceCategory">object of ServiceCategory</param>
        /// <returns>id of ServiceCategory</returns>
        int AddServiceCategory(MvServiceCategory mvServiceCategory);

        /// <summary>
        /// Get ServiceCategory Information
        /// </summary>
        /// <param name="serviceCategoryId">id of ServiceCategory</param>
        /// <returns>List of ServiceCategories</returns>
        List<MvServiceCategory> GetServiceCategory(int serviceCategoryId, string searchText);

        /// <summary>
        /// Edit existing ServiceCategory
        /// </summary>
        /// <param name="mvServiceCategory">object of  ServiceCategory</param>
        void EditServiceCategory(MvServiceCategory mvServiceCategory);

        /// <summary>
        /// Delete ServiceCategory
        /// </summary>
        /// <param name="serviceCategoryId">id of ServiceCategory</param>
        void DeleteServiceCategory(int serviceCategoryId);
    }
}
