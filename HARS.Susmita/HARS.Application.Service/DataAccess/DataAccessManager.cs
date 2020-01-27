using HARS.Application.LLBL.SqlServer;

namespace HARS.Application.Service
{
    public class DataAccessManager : DataAccessAdapter
    {

        public DataAccessManager() : base()
        {
        }

        public DataAccessManager(bool keepConnectionOpen) : base(true)
        {
        }
    }
}
