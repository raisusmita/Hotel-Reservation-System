using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Reservation;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{

    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class ReservationController : ControllerBase
    {
        IReservationService reservationService;

        public ReservationController()
        {
            reservationService = new ReservationService();
        }

        [HttpPost]
        public IActionResult Reservation([FromBody] MvReservation reservation)
        {
            try
            {
                int reservationId = reservationService.AddReservation(reservation);
                return Ok(reservationId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Reservation(int reservationId)
        {
            try
            {
                var reservations = reservationService.GetReservation(reservationId);
                return Ok(reservations);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Reservation")]
        public IActionResult EditReservation([FromBody] MvReservation reservation)
        {
            try
            {
                reservationService.EditReservation(reservation);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Reservation")]
        public IActionResult DeleteReservation(int reservationId)
        {
            try
            {
                reservationService.DeleteReservation(reservationId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}