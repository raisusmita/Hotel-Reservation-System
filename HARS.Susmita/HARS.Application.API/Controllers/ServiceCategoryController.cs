using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.ServiceCategory;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{

    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class ServiceCategoryController : ControllerBase
    {
        IServiceCategoryService serviceCategoryService;

        public ServiceCategoryController()
        {
            serviceCategoryService = new ServiceCategoryService();
        }

        [HttpPost]
        public IActionResult ServiceCategory([FromBody] MvServiceCategory serviceCategory)
        {
            try
            {
                int serviceCategoryId = serviceCategoryService.AddServiceCategory(serviceCategory);
                return Ok(serviceCategoryId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ServiceCategory(int serviceCategoryId, string searchText)
        {
            try
            {
                var serviceCategories = serviceCategoryService.GetServiceCategory(serviceCategoryId, searchText);
                return Ok(serviceCategories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("ServiceCategory")]
        public IActionResult EditServiceCategory([FromBody] MvServiceCategory serviceCategory)
        {
            try
            {
                serviceCategoryService.EditServiceCategory(serviceCategory);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("ServiceCategory")]
        public IActionResult DeleteServiceCategory(int serviceCategoryId)
        {
            try
            {
                serviceCategoryService.DeleteServiceCategory(serviceCategoryId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}