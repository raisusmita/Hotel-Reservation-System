using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Booking
{
    public class BookingService : IBookingService
    {

        public string AddBooking(MvBooking booking)
        {
            string json = string.Empty;

            ActionProcedures.SpBookingIns(JsonConvert.SerializeObject(booking, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref json);
            return json;
        }

        public void DeleteBooking(int bookingId)
        {
            ActionProcedures.SpBookingDel(bookingId);
        }

        public void EditBooking(MvBooking booking)
        {
            ActionProcedures.SpBookingUpd(JsonConvert.SerializeObject(booking, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvBooking> GetBooking(int bookingId, string searchText)
        {
            return DataAccessHelper.FetchDerivedModel<MvBooking>(RetrievalProcedures.GetSpBookingSelCallAsQuery(bookingId, searchText));

        }


    }
}
