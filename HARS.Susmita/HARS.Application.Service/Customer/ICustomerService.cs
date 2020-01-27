using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Customer
{
    public interface ICustomerService
    {
        /// <summary>
        /// Add New Customer
        /// </summary>
        /// <param name="mvCustomer">object of customer</param>
        /// <returns>id of customer</returns>
        string AddCustomer(MvCustomer mvCustomer);

        /// <summary>
        /// Get Customer Information
        /// </summary>
        /// <param name="customerId">id of customer</param>
        /// <returns>List of customers</returns>
        List<MvCustomer> GetCustomer(int customerId, string searchText);

        /// <summary>
        /// Edit existing customer
        /// </summary>
        /// <param name="mvCustomer">object of  customer</param>
        void EditCustomer(MvCustomer mvCustomer);

        /// <summary>
        /// Delete Customer
        /// </summary>
        /// <param name="customerId">id of customer</param>
        void DeleteCustomer (int customerId);
    }
}
