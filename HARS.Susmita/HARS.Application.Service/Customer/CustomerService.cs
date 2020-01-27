using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Customer
{
    public class CustomerService : ICustomerService
    {
        public int customerId;

        public string AddCustomer(MvCustomer customer)
        {
            string json = string.Empty;
            ActionProcedures.SpCustomerIns(JsonConvert.SerializeObject(customer, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref json);
            return json;
        }

        public void DeleteCustomer(int customerId)
        {
            ActionProcedures.SpCustomerDel(customerId);
        }

        public void EditCustomer(MvCustomer customer)
        {
            ActionProcedures.SpCustomerUpd(JsonConvert.SerializeObject(customer, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvCustomer> GetCustomer(int customerId,  string searchText)
        {
               return DataAccessHelper.FetchDerivedModel<MvCustomer>(RetrievalProcedures.GetSpCustomerSelCallAsQuery(customerId, searchText));

        }
    }
}
