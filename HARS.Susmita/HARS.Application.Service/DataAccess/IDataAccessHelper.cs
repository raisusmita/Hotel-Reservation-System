using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace HARS.Application.Service
{
    public interface IDataAccessHelper
    {
        List<T> FetchDerivedModel<T>(IRetrievalQuery qry);

        DataAccessManager GetAdapter();
    }
}