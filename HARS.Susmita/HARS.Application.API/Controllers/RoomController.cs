using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Room;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{

    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class RoomController : ControllerBase
    {
        IRoomService roomService;

        public RoomController()
        {
            roomService = new RoomService();
        }

        [HttpPost]
        public IActionResult Room([FromBody] MvRoom room)
        {
            try
            {
                int roomId = roomService.AddRoom(room);
                return Ok(roomId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Room(int roomId)
        {
            try
            {
                var rooms = roomService.GetRoom(roomId);
                return Ok(rooms);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Room")]
        public IActionResult EditRoom([FromBody] MvRoom room)
        {
            try
            {
                roomService.EditRoom(room);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Room")]
        public IActionResult DeleteRoom(int roomId)
        {
            try
            {
                roomService.DeleteRoom(roomId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}