using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Season
{
    public class SeasonService : ISeasonService
    {
        public int seasonId;

        public int AddSeason(MvSeason season)
        {
            seasonId = 0;
            ActionProcedures.SpSeasonIns(JsonConvert.SerializeObject(season, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref seasonId);
            return seasonId;
        }

        public void DeleteSeason(int seasonId)
        {
            ActionProcedures.SpSeasonDel(seasonId);
        }

        public void EditSeason(MvSeason season)
        {
            ActionProcedures.SpSeasonUpd(JsonConvert.SerializeObject(season, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvSeason> GetSeason(int seasonId, string searchText)
        {
            return DataAccessHelper.FetchDerivedModel<MvSeason>(RetrievalProcedures.GetSpSeasonSelCallAsQuery(seasonId, searchText));

        }
    }
}
