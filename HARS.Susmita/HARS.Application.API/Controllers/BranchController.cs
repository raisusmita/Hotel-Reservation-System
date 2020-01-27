using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Branch;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{

    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class BranchController : ControllerBase
    {
        IBranchService branchService;

        public BranchController()
        {
            branchService = new BranchService();
        }

        [HttpPost]
        public IActionResult Branch([FromBody] MvBranch branch)
        {
            try
            {
                string branchId = branchService.AddBranch(branch);
                return Ok(branchId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Branch(int branchId, string searchText)
        {
            try
            {
                var branches = branchService.GetBranch(branchId, searchText);
                return Ok(branches);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Branch")]
        public IActionResult EditBranch([FromBody] MvBranch branch)
        {
            try
            {
                branchService.EditBranch(branch);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Branch")]
        public IActionResult DeleteBranch(int branchId)
        {
            try
            {
                branchService.DeleteBranch(branchId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}