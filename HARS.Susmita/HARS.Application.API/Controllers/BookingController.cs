using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Booking;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{

    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]


    [ApiController]
    public class BookingController : ControllerBase
    {
        IBookingService bookingService;

        public BookingController()
        {
            bookingService = new BookingService();
        }

        [HttpPost]
        public IActionResult Booking([FromBody] MvBooking booking)
        {
            try
            {
                string json = bookingService.AddBooking(booking);
                return Ok(json);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Booking(int bookingId, string searchText)
        {
            try
            {
                var bookings = bookingService.GetBooking(bookingId, searchText);
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Booking")]
        public IActionResult EditBooking([FromBody] MvBooking booking)
        {
            try
            {
                bookingService.EditBooking(booking);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Booking")]
        public IActionResult DeleteBooking(int bookingId)
        {
            try
            {
                bookingService.DeleteBooking(bookingId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}