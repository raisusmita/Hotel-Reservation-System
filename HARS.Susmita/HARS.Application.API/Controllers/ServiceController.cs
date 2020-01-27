using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{
    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class ServiceController : ControllerBase
    {
        IServiceService serviceService;

        public ServiceController()
        {
            serviceService = new ServiceService();
        }

        [HttpPost]
        public IActionResult Service([FromBody] MvService service)
        {
            try
            {
                int serviceId = serviceService.AddService(service);
                return Ok(serviceId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Service(int serviceId, string searchText)
        {
            try
            {
                var services = serviceService.GetService(serviceId, searchText);
                return Ok(services);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Service")]
        public IActionResult EditService([FromBody] MvService service)
        {
            try
            {
                serviceService.EditService(service);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Service")]
        public IActionResult DeleteService(int serviceId)
        {
            try
            {
                serviceService.DeleteService(serviceId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}