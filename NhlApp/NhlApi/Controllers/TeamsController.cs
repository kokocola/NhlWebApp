using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Helpers;
using Lib.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhlDAL;

namespace NhlApi.Controllers
{
    [Produces("application/json")]
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        INhlService nhlService;
        public TeamsController()
        {
            nhlService = new NhlService();
        }
        // GET: api/Teams
        [HttpGet]
        public IActionResult Get()
        {
            var item = ApiUtility.SerializeObject(nhlService.GetAllTeams());
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // GET: api/Teams/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var item = nhlService.GetTeamById(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
