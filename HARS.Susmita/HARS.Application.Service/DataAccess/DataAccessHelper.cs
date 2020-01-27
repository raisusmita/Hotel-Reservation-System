using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Collections.Generic;


namespace HARS.Application.Service
{
    public static class DataAccessHelper 
    {
        public static List<T> FetchDerivedModel<T>(IRetrievalQuery qry)
        {
            List<T> pmv = new List<T>();
            using (DataAccessManager adapter = GetAdapter())
            {
                pmv = adapter.FetchProjection<T>(qry);
                adapter.CloseConnection();
            }
            return pmv;
        }

        public static DataAccessManager GetAdapter()
        {
                var adapter = new DataAccessManager(true)
                {
                    CompatibilityLevel = SqlServerCompatibilityLevel.SqlServer2012,
                    CommandTimeOut = 180
                };
               
                return adapter;
        }

    }
}