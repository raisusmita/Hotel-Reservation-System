using System;
using System.Collections.Generic;
using System.Text;
using HARS.Application.LLBL.SqlServer;
using HARS.Application.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HARS.Application.Service.Room
{
    public class RoomService : IRoomService
    {
        public int roomId;

        public int AddRoom(MvRoom room)
        {
            roomId = 0;
            ActionProcedures.SpRoomIns(JsonConvert.SerializeObject(room, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), ref roomId);
            return roomId;
        }

        public void DeleteRoom(int roomId)
        {
            ActionProcedures.SpRoomDel(roomId);
        }

        public void EditRoom(MvRoom room)
        {
            ActionProcedures.SpRoomUpd(JsonConvert.SerializeObject(room, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));

        }

        public List<MvRoom> GetRoom(int roomId)
        {
            return DataAccessHelper.FetchDerivedModel<MvRoom>(RetrievalProcedures.GetSpRoomSelCallAsQuery(roomId));

        }
    }
}
