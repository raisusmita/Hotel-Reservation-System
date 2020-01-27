using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Service
{
    public interface IServiceService
    {
        /// <summary>
        /// Add New Service
        /// </summary>
        /// <param name="mvServiceService">object of Service</param>
        /// <returns>id of Service</returns>
        int AddService(MvService mvService);

        /// <summary>
        /// Get Service Information
        /// </summary>
        /// <param name="serviceId">id of Service</param>
        /// <returns>List of Services</returns>
        List<MvService> GetService(int serviceId, string searchText);

        /// <summary>
        /// Edit existing Service
        /// </summary>
        /// <param name="mvServiceService">object of  Service</param>
        void EditService(MvService mvService);

        /// <summary>
        /// Delete Service
        /// </summary>
        /// <param name="serviceId">id of Service</param>
        void DeleteService(int serviceId);
    }
}
