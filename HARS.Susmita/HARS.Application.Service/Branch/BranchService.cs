using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Branch
{
    public class BranchService : IBranchService
    {

        public string AddBranch(MvBranch branch)
        {
            string json = string.Empty; 
            ActionProcedures.SpBranchIns(JsonConvert.SerializeObject(branch, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref json);
            return json;
        }

        public void DeleteBranch(int branchId)
        {
            ActionProcedures.SpBranchDel(branchId);
        }

        public void EditBranch(MvBranch branch)
        {
            ActionProcedures.SpBranchUpd(JsonConvert.SerializeObject(branch, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvBranch> GetBranch(int branchId, string searchText)
        {
            return DataAccessHelper.FetchDerivedModel<MvBranch>(RetrievalProcedures.GetSpBranchSelCallAsQuery(branchId, searchText));

        }
    }
}
