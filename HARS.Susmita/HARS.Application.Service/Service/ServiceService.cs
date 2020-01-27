using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace HARS.Application.Service.Service
{
    public class ServiceService : IServiceService
    {
        public int serviceId;
        public int AddService(MvService service)
        {
            serviceId = 0;
            ActionProcedures.SpServiceIns(JsonConvert.SerializeObject(service, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref serviceId);
            return serviceId;
        }

        public void DeleteService(int serviceId)
        {
            ActionProcedures.SpServiceDel(serviceId);
        }

        public void EditService(MvService service)
        {
            ActionProcedures.SpServiceUpd(JsonConvert.SerializeObject(service, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvService> GetService(int serviceId, string searchText)
        {
            return DataAccessHelper.FetchDerivedModel<MvService>(RetrievalProcedures.GetSpServiceSelCallAsQuery(serviceId, searchText));

        }
    }
}
