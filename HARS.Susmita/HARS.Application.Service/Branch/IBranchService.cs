using HARS.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Branch
{
    public interface IBranchService
    {
        /// <summary>
        /// Add New Branch
        /// </summary>
        /// <param name="mvBranch">object of branch</param>
        /// <returns>id of branch</returns>
        string AddBranch(MvBranch mvBranch);

        /// <summary>
        /// Get Branch Information
        /// </summary>
        /// <param name="branchId">id of branch</param>
        /// <returns>List of branches</returns>
        List<MvBranch> GetBranch(int branchId, string searchText);

        /// <summary>
        /// Edit existing branch
        /// </summary>
        /// <param name="mvBranch">object of  branch</param>
        void EditBranch(MvBranch mvBranch);

        /// <summary>
        /// Delete Branch
        /// </summary>
        /// <param name="branchId">id of branch</param>
        void DeleteBranch(int branchId);
    }
}
