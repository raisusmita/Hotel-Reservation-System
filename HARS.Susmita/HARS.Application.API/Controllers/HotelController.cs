using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Hotel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{
    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        IHotelService hotelService;

        public HotelController()
        {
            hotelService = new HotelService();
        }

        [HttpPost]
        public IActionResult Hotel([FromBody] MvHotel hotel)
        {
            try
            {
                int hotelId = hotelService.AddHotel(hotel);
                return Ok(hotelId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Hotel(int hotelId, string searchText)
        {
            try
            {
                var hotels = hotelService.GetHotel(hotelId, searchText);
                return Ok(hotels);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Hotel")]
        public IActionResult EditHotel([FromBody] MvHotel hotel)
        {
            try
            {
                hotelService.EditHotel(hotel);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Hotel")]
        public IActionResult DeleteHotel(int hotelId)
        {
            try
            {
                hotelService.DeleteHotel(hotelId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}