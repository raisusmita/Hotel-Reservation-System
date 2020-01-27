using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Customer;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{
  
    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService customerService;

        public CustomerController()
        {
            customerService = new CustomerService();
        }

        [HttpPost]
        public IActionResult Customer([FromBody] MvCustomer customer)
        {
            try
            {
                string json = customerService.AddCustomer(customer);
                return Ok(json);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Customer(int customerId, string searchText)
        {
            try
            {
                var customers = customerService.GetCustomer(customerId, searchText);
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Customer")]
        public IActionResult EditCustomer([FromBody] MvCustomer customer)
        {
            try
            {
                customerService.EditCustomer(customer);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Customer")]
        public IActionResult DeleteCustomer(int customerId)
        {
            try
            {
                customerService.DeleteCustomer(customerId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}