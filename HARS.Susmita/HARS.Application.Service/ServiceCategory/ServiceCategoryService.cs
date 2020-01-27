using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.ServiceCategory
{
    public class ServiceCategoryService : IServiceCategoryService
    {
        public int serviceCategoryId;

        public int AddServiceCategory(MvServiceCategory serviceCategory)
        {
            serviceCategoryId = 0;
            ActionProcedures.SpServiceCategoryIns(JsonConvert.SerializeObject(serviceCategory, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref serviceCategoryId);
            return serviceCategoryId;
        }

        public void DeleteServiceCategory(int serviceCategoryId)
        {
            ActionProcedures.SpServiceCategoryDel(serviceCategoryId);
        }

        public void EditServiceCategory(MvServiceCategory serviceCategory)
        {
            ActionProcedures.SpServiceCategoryUpd(JsonConvert.SerializeObject(serviceCategory, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvServiceCategory> GetServiceCategory(int serviceCategoryId, string searchText)
        {
            return DataAccessHelper.FetchDerivedModel<MvServiceCategory>(RetrievalProcedures.GetSpServiceCategorySelCallAsQuery(serviceCategoryId, searchText));

        }
    }
}
