using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Hotel
{
    public class HotelService : IHotelService
    {
        public int hotelId;
        public int AddHotel(MvHotel hotel)
        {
            hotelId = 0;
            ActionProcedures.SpHotelIns(JsonConvert.SerializeObject(hotel, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref hotelId);
            return hotelId;
        }


        public List<MvHotel> GetHotel(int hotelId, string searchText )
        {
            return DataAccessHelper.FetchDerivedModel<MvHotel>(RetrievalProcedures.GetSpHotelSelCallAsQuery(hotelId, searchText));

        }

        public void EditHotel(MvHotel hotel)
        {
            ActionProcedures.SpHotelUpd(JsonConvert.SerializeObject(hotel, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public void DeleteHotel(int hotelId)
        {
            ActionProcedures.SpHotelDel(hotelId);
        }
    }
}
