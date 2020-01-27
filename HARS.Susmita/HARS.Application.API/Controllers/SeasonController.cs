using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HARS.Application.Model;
using HARS.Application.Service.Season;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HARS.Application.API.Controllers
{

    [EnableCors("AllowCors"), Route("api/[controller]/[action]")]

    [ApiController]
    public class SeasonController : ControllerBase
    {
        ISeasonService seasonService;

        public SeasonController()
        {
            seasonService = new SeasonService();
        }

        [HttpPost]
        public IActionResult Season([FromBody] MvSeason season)
        {
            try
            {
                int seasonId = seasonService.AddSeason(season);
                return Ok(seasonId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Season(int seasonId, string searchText)
        {
            try
            {
                var seasons = seasonService.GetSeason(seasonId, searchText);
                return Ok(seasons);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Season")]
        public IActionResult EditSeason([FromBody] MvSeason season)
        {
            try
            {
                seasonService.EditSeason(season);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ActionName("Season")]
        public IActionResult DeleteSeason(int seasonId)
        {
            try
            {
                seasonService.DeleteSeason(seasonId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}