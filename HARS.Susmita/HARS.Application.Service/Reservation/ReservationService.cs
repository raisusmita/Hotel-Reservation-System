using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Reservation
{
    public class ReservationService : IReservationService
    {
        public int reservationId;

        public int AddReservation(MvReservation reservation)
        {
            reservationId = 0;
            ActionProcedures.SpReservationIns(JsonConvert.SerializeObject(reservation, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref reservationId);
            return reservationId;
        }

        public void DeleteReservation(int reservationId)
        {
            ActionProcedures.SpReservationDel(reservationId);

        }

        public void EditReservation(MvReservation reservation)
        {
            ActionProcedures.SpReservationUpd(JsonConvert.SerializeObject(reservation, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvReservation> GetReservation(int reservationId)
        {
            return DataAccessHelper.FetchDerivedModel<MvReservation>(RetrievalProcedures.GetSpReservationSelCallAsQuery(reservationId));

        }
    }
}
